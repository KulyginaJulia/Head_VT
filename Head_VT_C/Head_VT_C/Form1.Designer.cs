namespace Head_VT_C
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
            this.glControl1 = new OpenTK.GLControl();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_max = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Quad = new System.Windows.Forms.RadioButton();
            this.radioButton_Tex = new System.Windows.Forms.RadioButton();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 30);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(225, 223);
            this.glControl1.TabIndex = 3;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(634, 27);
            this.menu.TabIndex = 4;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(92, 23);
            this.toolStripComboBox1.Text = "menu";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 259);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(225, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(189, 290);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(35, 13);
            this.label_max.TabIndex = 6;
            this.label_max.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // radioButton_Quad
            // 
            this.radioButton_Quad.AutoSize = true;
            this.radioButton_Quad.Checked = true;
            this.radioButton_Quad.Location = new System.Drawing.Point(539, 58);
            this.radioButton_Quad.Name = "radioButton_Quad";
            this.radioButton_Quad.Size = new System.Drawing.Size(75, 17);
            this.radioButton_Quad.TabIndex = 8;
            this.radioButton_Quad.TabStop = true;
            this.radioButton_Quad.Text = "Квадраты";
            this.radioButton_Quad.UseVisualStyleBackColor = true;
            // 
            // radioButton_Tex
            // 
            this.radioButton_Tex.AutoSize = true;
            this.radioButton_Tex.Location = new System.Drawing.Point(539, 82);
            this.radioButton_Tex.Name = "radioButton_Tex";
            this.radioButton_Tex.Size = new System.Drawing.Size(74, 17);
            this.radioButton_Tex.TabIndex = 9;
            this.radioButton_Tex.TabStop = true;
            this.radioButton_Tex.Text = "Текстуры";
            this.radioButton_Tex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.radioButton_Tex);
            this.Controls.Add(this.radioButton_Quad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Quad;
        private System.Windows.Forms.RadioButton radioButton_Tex;
    }
}

