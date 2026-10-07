using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace application
{
    public partial class Menu : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        // Para mostrar el iusuario en el menu
        String usuario;
        public Menu(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Bienvenido, " + this.usuario;
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter= "Imagenes |*.jpg;*.jpeg;*.png;";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                pcb_Img.Image = new Bitmap(fileDialog.FileName);
                pcb_Img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pcb_Img.Image = null;
        }

        //MOstramos el video en el pictureBox
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pcb_Img.Image = bitmap;
        }


        //Al presionar el boton de encendido, se enciende la camara usando la camara 0
        private void button1_Click_2(object sender, EventArgs e)
        {
            if(btn_encender.Text == "Encender Camara")
            {
                btn_encender.Text = "Apagar Camara";
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna cámara.");
                    return;
                }
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            else
            {
                closeCamera();
                pcb_Img.Image = null;
               
            }
        }
        

        private void button1_Click_3(object sender, EventArgs e)
        {
            if(pcb_Img.Image != null)
            {
                closeCamera();
            }
            else
            {
                MessageBox.Show("Primero enciende la cámara");
            }
        }

        private void closeCamera() {
            if(videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                btn_encender.Text = "Encender Camara";
            }
        }
    }
}
