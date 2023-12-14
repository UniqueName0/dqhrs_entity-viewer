using BizHawk.Bizware.BizwareGL;
using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Emulation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace WindowsFormsApp1
{
    [ExternalTool("dqhrs-entity-viewer")]
    public partial class Form1 : ToolFormBase, IExternalToolForm
    {
        public IGuiRenderer guiRenderer;
        public IGL gl;
        public ApiContainer? _maybeAPIContainer { get; set; }
        private ApiContainer APIs => _maybeAPIContainer!;
        private long currentAddress = 0x00143B20;
        private uint currentRoom = 0;
        private List<long> EntityAddresses = new();


        static long roomAddress = 0x00143c1e;


        public Form1() => InitializeComponent();


        protected override string WindowTitleStatic => "dqhrs-entity-viewer";


        public override void Restart()
        {
            APIs.Memory.UseMemoryDomain(APIs.Memory.MainMemoryName);

            
        }

        

        private void RoomChanged() {
            entityList.Items.Clear();
            currentAddress = 0x00143B20;
            entityList.Items.Add("player");
            EntityAddresses.Add(currentAddress);
            for (long i = 0x00143C3C; i < 0x00143C3C+(80*0x11c); i+=0x11c) {
                uint xPos = APIs.Memory.ReadU32(i);
                uint yPos = APIs.Memory.ReadU32(i+4);
                if (xPos != 0 && yPos != 0) {
                    entityList.Items.Add("unknown");
                    EntityAddresses.Add(i);
                }
            }
        }

        protected override void UpdateAfter()
        {
            uint cRoom = APIs.Memory.ReadU32(roomAddress);
            roomId.Text = "room id: " + cRoom.ToString();
            if (cRoom != currentRoom)
            {
                RoomChanged();
                currentRoom = cRoom;
            }

            entityXBox.Value = APIs.Memory.ReadU32(currentAddress);
            entityYBox.Value = APIs.Memory.ReadU32(currentAddress + 4);
            entityZBox.Value = APIs.Memory.ReadU32(currentAddress + 0x14);
            entityIdBox.Value = APIs.Memory.ReadU8(currentAddress + 0xFa);

            //System.Numerics.Vector2 CamPos = new((int)APIs.Memory.ReadU32(0x00143B20) - 33023, (int)APIs.Memory.ReadU32(0x00143B24) - 24831);
            System.Numerics.Vector2 CamPos = new((int)APIs.Memory.ReadU32(0x00140f4c), (int)APIs.Memory.ReadU32(0x00140f50));
            if (CamPos.X < 0) CamPos.X = 0;
            if (CamPos.Y < 0) CamPos.Y = 0;
            

            System.Numerics.Vector2 ScrScale = new(APIs.EmuClient.ScreenWidth() / 66046f, APIs.EmuClient.ScreenHeight() * 0.5f / 49662f);
            System.Numerics.Vector2 ObjPos = new((float)Math.Floor(ScrScale.X*((float)entityXBox.Value - CamPos.X)), (float)Math.Floor(ScrScale.Y * ((float)entityYBox.Value - CamPos.Y)));
            

            APIs.Gui.WithSurface(DisplaySurfaceID.Client, () =>
            {
                

                foreach (long addr in EntityAddresses)
                {
                    uint entX = APIs.Memory.ReadU32(addr);
                    uint entY = APIs.Memory.ReadU32(addr + 4);
                    System.Numerics.Vector2 entPos = new((float)Math.Floor(ScrScale.X * ((float)entX - CamPos.X)), (float)Math.Floor(ScrScale.Y * ((float)entY - CamPos.Y)));
                    APIs.Gui.DrawEllipse((int)entPos.X, (int)Math.Floor(entPos.Y + APIs.EmuClient.ScreenHeight() * 0.5f), 10, 10, Color.Black, Color.Blue, DisplaySurfaceID.Client);

                }
                APIs.Gui.DrawEllipse((int)ObjPos.X, (int)Math.Floor(ObjPos.Y + APIs.EmuClient.ScreenHeight() * 0.5f), 10, 10, Color.Black, Color.Red, DisplaySurfaceID.Client);

            });
        }

        private void entityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAddress = EntityAddresses[entityList.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HexEditor hexEditor = (HexEditor)APIs.Tool.GetTool("HexEditor");
            MethodInfo gotoMethod = hexEditor.GetType().GetMethod("GoToAddress", BindingFlags.NonPublic | BindingFlags.Instance);
            gotoMethod.Invoke(hexEditor, new object[] { currentAddress });
        }

        private void entityIdBox_ValueChanged(object sender, EventArgs e)
        {
            APIs.Memory.WriteU8(currentAddress + 0xFa, (uint)entityIdBox.Value);
        }

        private void entityXBox_ValueChanged(object sender, EventArgs e)
        {
            APIs.Memory.WriteU32(currentAddress, (uint)entityXBox.Value);
        }

        private void entityYBox_ValueChanged(object sender, EventArgs e)
        {
            APIs.Memory.WriteU32(currentAddress + 4, (uint)entityYBox.Value);
        }

        private void entityZBox_ValueChanged(object sender, EventArgs e)
        {
            APIs.Memory.WriteU32(currentAddress + 0x14, (uint)entityZBox.Value);
        }

        private void refresh_click(object sender, EventArgs e)
        {
            RoomChanged();
        }
    }
}
