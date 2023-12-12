namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entityList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entityIdBox = new System.Windows.Forms.NumericUpDown();
            this.entityXBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.entityYBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roomId = new System.Windows.Forms.Label();
            this.entityZBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entityIdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityYBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityZBox)).BeginInit();
            this.SuspendLayout();
            // 
            // entityList
            // 
            this.entityList.FormattingEnabled = true;
            this.entityList.ItemHeight = 16;
            this.entityList.Items.AddRange(new object[] {
            "player",
            "ent1",
            "ent2"});
            this.entityList.Location = new System.Drawing.Point(13, 45);
            this.entityList.Name = "entityList";
            this.entityList.Size = new System.Drawing.Size(90, 212);
            this.entityList.TabIndex = 0;
            this.entityList.SelectedIndexChanged += new System.EventHandler(this.entityList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "entities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "chat id:";
            // 
            // entityIdBox
            // 
            this.entityIdBox.Location = new System.Drawing.Point(182, 56);
            this.entityIdBox.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.entityIdBox.Name = "entityIdBox";
            this.entityIdBox.Size = new System.Drawing.Size(120, 22);
            this.entityIdBox.TabIndex = 3;
            this.entityIdBox.ValueChanged += new System.EventHandler(this.entityIdBox_ValueChanged);
            // 
            // entityXBox
            // 
            this.entityXBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.entityXBox.Location = new System.Drawing.Point(182, 84);
            this.entityXBox.Maximum = new decimal(new int[] {
            2147483600,
            0,
            0,
            0});
            this.entityXBox.Name = "entityXBox";
            this.entityXBox.Size = new System.Drawing.Size(120, 22);
            this.entityXBox.TabIndex = 5;
            this.entityXBox.ValueChanged += new System.EventHandler(this.entityXBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "x:";
            // 
            // entityYBox
            // 
            this.entityYBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.entityYBox.Location = new System.Drawing.Point(182, 112);
            this.entityYBox.Maximum = new decimal(new int[] {
            2147483600,
            0,
            0,
            0});
            this.entityYBox.Name = "entityYBox";
            this.entityYBox.Size = new System.Drawing.Size(120, 22);
            this.entityYBox.TabIndex = 7;
            this.entityYBox.ValueChanged += new System.EventHandler(this.entityYBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "open in memory editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomId
            // 
            this.roomId.AutoSize = true;
            this.roomId.Location = new System.Drawing.Point(16, 264);
            this.roomId.Name = "roomId";
            this.roomId.Size = new System.Drawing.Size(58, 16);
            this.roomId.TabIndex = 9;
            this.roomId.Text = "room id: ";
            // 
            // entityZBox
            // 
            this.entityZBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.entityZBox.Location = new System.Drawing.Point(182, 140);
            this.entityZBox.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.entityZBox.Name = "entityZBox";
            this.entityZBox.Size = new System.Drawing.Size(120, 22);
            this.entityZBox.TabIndex = 11;
            this.entityZBox.ValueChanged += new System.EventHandler(this.entityZBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "z:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 290);
            this.Controls.Add(this.entityZBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entityYBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entityXBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entityIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entityList);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.entityIdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityYBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityZBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox entityList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown entityIdBox;
        private System.Windows.Forms.NumericUpDown entityXBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown entityYBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label roomId;
        private System.Windows.Forms.NumericUpDown entityZBox;
        private System.Windows.Forms.Label label5;
    }
}

