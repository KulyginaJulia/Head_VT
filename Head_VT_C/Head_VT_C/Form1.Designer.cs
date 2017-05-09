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
            this.Open_Menu = new System.Windows.Forms.ToolStripComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_max = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Quad = new System.Windows.Forms.RadioButton();
            this.radioButton_Tex = new System.Windows.Forms.RadioButton();
            this.radioButton_strip = new System.Windows.Forms.RadioButton();
            this.label_LayerCurrent = new System.Windows.Forms.Label();
            this.trackBar_TFMin = new System.Windows.Forms.TrackBar();
            this.trackBar_TFHeight = new System.Windows.Forms.TrackBar();
            this.label_TFMinCurrent = new System.Windows.Forms.Label();
            this.label_TFMaxCurrent = new System.Windows.Forms.Label();
            this.label_TFHeightCurrent = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 172);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(628, 294);
            this.glControl1.TabIndex = 3;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_Menu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(663, 27);
            this.menu.TabIndex = 4;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Open_Menu
            // 
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(92, 23);
            this.Open_Menu.Text = "Open";
            this.Open_Menu.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 30);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(372, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(342, 62);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(42, 13);
            this.label_max.TabIndex = 6;
            this.label_max.Text = "label_Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
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
            // radioButton_strip
            // 
            this.radioButton_strip.AutoSize = true;
            this.radioButton_strip.Location = new System.Drawing.Point(539, 106);
            this.radioButton_strip.Name = "radioButton_strip";
            this.radioButton_strip.Size = new System.Drawing.Size(72, 17);
            this.radioButton_strip.TabIndex = 10;
            this.radioButton_strip.TabStop = true;
            this.radioButton_strip.Text = "QuadStrip";
            this.radioButton_strip.UseVisualStyleBackColor = true;
            // 
            // label_LayerCurrent
            // 
            this.label_LayerCurrent.AutoSize = true;
            this.label_LayerCurrent.Location = new System.Drawing.Point(394, 30);
            this.label_LayerCurrent.Name = "label_LayerCurrent";
            this.label_LayerCurrent.Size = new System.Drawing.Size(53, 13);
            this.label_LayerCurrent.TabIndex = 11;
            this.label_LayerCurrent.Text = "label_curr";
            // 
            // trackBar_TFMin
            // 
            this.trackBar_TFMin.Location = new System.Drawing.Point(12, 74);
            this.trackBar_TFMin.Name = "trackBar_TFMin";
            this.trackBar_TFMin.Size = new System.Drawing.Size(365, 45);
            this.trackBar_TFMin.TabIndex = 12;
            this.trackBar_TFMin.Scroll += new System.EventHandler(this.trackBar_TFMin_Scroll);
            // 
            // trackBar_TFHeight
            // 
            this.trackBar_TFHeight.Location = new System.Drawing.Point(12, 125);
            this.trackBar_TFHeight.Name = "trackBar_TFHeight";
            this.trackBar_TFHeight.Size = new System.Drawing.Size(365, 45);
            this.trackBar_TFHeight.TabIndex = 13;
            this.trackBar_TFHeight.Scroll += new System.EventHandler(this.trackBar_TFHeight_Scroll);
            // 
            // label_TFMinCurrent
            // 
            this.label_TFMinCurrent.AutoSize = true;
            this.label_TFMinCurrent.Location = new System.Drawing.Point(24, 106);
            this.label_TFMinCurrent.Name = "label_TFMinCurrent";
            this.label_TFMinCurrent.Size = new System.Drawing.Size(48, 13);
            this.label_TFMinCurrent.TabIndex = 14;
            this.label_TFMinCurrent.Text = "label-min";
            // 
            // label_TFMaxCurrent
            // 
            this.label_TFMaxCurrent.AutoSize = true;
            this.label_TFMaxCurrent.Location = new System.Drawing.Point(342, 106);
            this.label_TFMaxCurrent.Name = "label_TFMaxCurrent";
            this.label_TFMaxCurrent.Size = new System.Drawing.Size(54, 13);
            this.label_TFMaxCurrent.TabIndex = 15;
            this.label_TFMaxCurrent.Text = "label_max";
            // 
            // label_TFHeightCurrent
            // 
            this.label_TFHeightCurrent.AutoSize = true;
            this.label_TFHeightCurrent.Location = new System.Drawing.Point(383, 130);
            this.label_TFHeightCurrent.Name = "label_TFHeightCurrent";
            this.label_TFHeightCurrent.Size = new System.Drawing.Size(64, 13);
            this.label_TFHeightCurrent.TabIndex = 16;
            this.label_TFHeightCurrent.Text = "label_height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 478);
            this.Controls.Add(this.label_TFHeightCurrent);
            this.Controls.Add(this.label_TFMaxCurrent);
            this.Controls.Add(this.label_TFMinCurrent);
            this.Controls.Add(this.trackBar_TFHeight);
            this.Controls.Add(this.trackBar_TFMin);
            this.Controls.Add(this.label_LayerCurrent);
            this.Controls.Add(this.radioButton_strip);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripComboBox Open_Menu;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Quad;
        private System.Windows.Forms.RadioButton radioButton_Tex;
        private System.Windows.Forms.RadioButton radioButton_strip;
        private System.Windows.Forms.Label label_LayerCurrent;
        private System.Windows.Forms.TrackBar trackBar_TFMin;
        private System.Windows.Forms.TrackBar trackBar_TFHeight;
        private System.Windows.Forms.Label label_TFMinCurrent;
        private System.Windows.Forms.Label label_TFMaxCurrent;
        private System.Windows.Forms.Label label_TFHeightCurrent;
    }
}

