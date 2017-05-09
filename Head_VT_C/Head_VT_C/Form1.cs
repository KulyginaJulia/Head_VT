//using OpenTK.Graphics.ES11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing.Imaging;

namespace Head_VT_C
{
    public partial class Form1 : Form
    {
        Bin bin = new Bin();
        View view = new View();
        bool loaded = false;
        int currentLayer;
        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps = {0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }
        
        public Form1()
        {
            InitializeComponent();
            //string glVersion = GL.GetString(StringName.Version);
            //string glslVersion = GL.GetString(StringName.ShadingLanguageVersion);
            
            //int BasicProgramID;
            //int BasicVertexShader;
            //int BasicFragmentShader;
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            
        }
      
        bool needReload = false;
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
     
            if (loaded)
            {
                if (radioButton_Quad.Checked == true)
                {
                    view.DrawQuads(currentLayer);
                }
                else
                {
                    if (radioButton_Tex.Checked == true)
                    {
                        if (needReload)
                        {
                            view.generateTextureImage(currentLayer);
                            view.Load2DTexture();
                            needReload = false;
                        }
                        view.DrawTexture();
                    }
                    else 
                    {
                        view.DrawQuadStrip(currentLayer);
                    }
                }
                
                glControl1.SwapBuffers();
                
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
                trackBar1.Maximum = bin.GetZ() - 1;
                glControl1.Width = bin.GetX() - 1;
                glControl1.Height = bin.GetY() - 1;

            }
            string temp = ""+bin.GetZ();
            label_max.Text = temp;
            label_LayerCurrent.Text = "Текущий уровень = " + currentLayer;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            label_LayerCurrent.Text = "Текущий уровень = " + currentLayer;
            needReload = true;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void trackBar_TFMin_Scroll(object sender, EventArgs e)
        {
            view.SetMinMaxTransferFunction(trackBar_TFMin.Value, trackBar_TFMin.Value + trackBar_TFHeight.Value);
            label_TFMinCurrent.Text = "Текущий минимум = " + trackBar_TFMin.Value;
            label_TFMaxCurrent.Text = "Текущий максимум = " + (trackBar_TFMin.Value + trackBar_TFHeight.Value);
            needReload = true;
        }

        private void trackBar_TFHeight_Scroll(object sender, EventArgs e)
        {
            view.SetMinMaxTransferFunction(trackBar_TFMin.Value, trackBar_TFMin.Value + trackBar_TFHeight.Value);
            label_TFHeightCurrent.Text = "Текущая ширина = " + trackBar_TFHeight.Value;
            label_TFMaxCurrent.Text = "Текущий максимум = " + (trackBar_TFMin.Value + trackBar_TFHeight.Value);
            needReload = true;
        }
    }

}
