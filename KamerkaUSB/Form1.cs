using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamerkaUSB
{
    public partial class KamerkaUSB : Form
    {
        KameraUSB camera;
        public KamerkaUSB()
        {
            InitializeComponent();
        }

        private void KamerkaUSB_Load(object sender, EventArgs e)
        {
            camera = new KameraUSB();
            List<string> drivers = camera.findDevice();

            foreach(string driver in drivers)
            {
                comboBoxSelectDriver.Items.Add(driver);
            }
            comboBoxSelectDriver.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(labelStatus.Text == "START")
            {
                labelStatus.Text = "STOP";
                camera = new KameraUSB();
                camera.startConnection(comboBoxSelectDriver.SelectedIndex, pictureBoxOfCamera);
            }
            else
            {
                labelStatus.Text = "START";
                camera.closeConnection();
            }
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            if (camera != null)
            {
                Bitmap bitMapa = (Bitmap)camera.makePhoto();

                if(savePhotoDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format;
                    switch(savePhotoDialog.FilterIndex)
                    {
                        case 1:
                            format = ImageFormat.Jpeg;
                            break;
                        default:
                            format = ImageFormat.Png;
                            break;
                    }
                    bitMapa.Save(savePhotoDialog.FileName, format);
                }
            }
        }

        private void buttonSetResolution_Click(object sender, EventArgs e)
        {
            if (camera != null)
                camera.setResolution();
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            if (camera != null)
                camera.setContrast();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (camera != null)
                camera.makeZoom(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            camera.makeVideo();
        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            camera.stopRecording();
        }
    }
}
