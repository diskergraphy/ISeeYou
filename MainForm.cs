using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace ISeeYou
{
    public partial class MainForm : Form
    {        
        IplImage m_cvImg;
        CvCapture m_cvCap;

        CvFaceData face;

        public MainForm()
        {
            InitializeComponent();
                        //helloㅓ
            //ㅗㅑ
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_cvCap = CvCapture.FromCamera(0);
            
            m_cvCap.FrameWidth = 320;
            m_cvCap.FrameHeight = 240;

            timer1.Interval = 20;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {    //카메라에서 프레임 가져온다.
            m_cvImg = m_cvCap.QueryFrame();
            //IplImage을 비트맵으로 전환
            pictureBox1.Image = m_cvImg.ToBitmap();

            label1.Text = face.LeftEyeRect.X+"";

        }
    }
}
