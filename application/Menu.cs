using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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
using static Mysqlx.Datatypes.Scalar.Types;

namespace application
{
    public partial class Menu : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        // Para mostrar el iusuario en el menu
        string usuario;
        long userId;

        public Menu(string usuario, long userId)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.userId = userId;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Bienvenido, " + this.usuario;
            pcb_Img.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeCamera();
    
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Imagenes |*.jpg;*.jpeg;*.png;";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Obtener la ruta raíz del reposito
                    string binPath = AppDomain.CurrentDomain.BaseDirectory;
                    string repoRoot = Path.GetFullPath(Path.Combine(binPath, @"..\..\"));


                    string targetFolder = Path.Combine(repoRoot, "resources", "images");

                    //Definir la ruta completa del archivo de destino
                    //string fileName = Path.GetFileName(fileDialog.FileName);
                    string extension = Path.GetExtension(fileDialog.FileName);
                    string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}{extension}";
                    string destPath = Path.Combine(targetFolder, fileName);

                    // Copiar el archivo seleccionado a la nueva carpeta
                    File.Copy(fileDialog.FileName, destPath, true);
                    this.pathimage = destPath;

                    if (pcb_Img.Image != null)
                    {
                        pcb_Img.Image.Dispose();
                    }

                    using (var stream = new FileStream(destPath, FileMode.Open, FileAccess.Read))
                    {
                        pcb_Img.Image = Image.FromStream(stream);
                    }
                    pcb_Img.SizeMode = PictureBoxSizeMode.StretchImage;
                    pcb_Img.Show();
                    MessageBox.Show($"Imagen guardada en:\n{destPath}", "Imagen cargada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al copiar la imagen:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pcb_Img.Image = bitmap;
        }


        //Al presionar el boton de encendido, se enciende la camara usando la camara 0
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (btn_encender.Text == "Encender Camara")
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

        string pathimage = "";
        private void button1_Click_3(object sender, EventArgs e)
        {
            if (pcb_Img.Image != null)
            {
                //Establece la base del repo. La ruta que toma por defecto es Bin, retrocedemos 2 y estamos una antes de application
                string repoRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
                //Establece la ruta despues de la base /resources/images y crea la carpeta si no existe
                string imagesDir = System.IO.Path.Combine(repoRoot, "Resources", "images");
                System.IO.Directory.CreateDirectory(imagesDir);

                // Build filename using date and time: DDmmYYYYHHMMSS -> ddMMyyyyHHmmss
                string timestamp = DateTime.Now.ToString("ddMMyyyyHHmmss");
                string filename = timestamp + ".jpg";
                pathimage = System.IO.Path.Combine(imagesDir, filename);

                // Clone the image to avoid GDI+ "generic error" when saving locked images
                using (var clone = new System.Drawing.Bitmap(pcb_Img.Image))
                {
                    clone.Save(pathimage, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                closeCamera();
                MessageBox.Show("Imagen guardada en: " + pathimage);
            }
        }

        private void closeCamera() {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                btn_encender.Text = "Encender Camara";
            }
        }
        public static int[,,] GetRGBMatrix(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;

            int[,,] rgbMatrix = new int[height, width, 3];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    rgbMatrix[y, x, 0] = pixel.R;
                    rgbMatrix[y, x, 1] = pixel.G;
                    rgbMatrix[y, x, 2] = pixel.B;
                }
            }

            return rgbMatrix;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pcb_Img.Image != null)
            {
                if(btn_encender.Text== "Apagar Camara")
                {
                    MessageBox.Show("Primero toma la foto");
                }else
                {
                    Bitmap bmp = new Bitmap(pcb_Img.Image);
                    int[,,] rgbMatrix = GetRGBMatrix(bmp);

                    string jsonMatrix = JsonConvert.SerializeObject(rgbMatrix);

                    using (MySqlConnection conn = Connection.GetConnection())
                    {
                        try {
                       
                            conn.Open();
                            string query = "INSERT INTO imagenes (id_usuario, imagen) VALUES (@usuario_id, @imagen_data)";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@usuario_id", this.userId);
                                cmd.Parameters.AddWithValue("@imagen_data", jsonMatrix);
                                cmd.ExecuteNonQuery();
                                long imagenId = cmd.LastInsertedId;
                            }
                            MessageBox.Show("Imagen guardada en la base de datos");
                        } catch(Exception ex)
                        {
                            MessageBox.Show(jsonMatrix);
                            MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                        
                        }
                    }
                }
            }
        }


        private void btn_procesar_Click(object sender, EventArgs e)
        {
            if (pcb_Img.Image != null)
            {
                if (btn_encender.Text == "Apagar Camara")
                {
                    MessageBox.Show("Primero toma la foto");
                }
                else
                {
                    //Form procesamiento = new Procesamiento(this.usuario, (Bitmap)pcb_Img.Image);
                    Form procesamiento = new Procesamiento(this.usuario, pathimage);
                    procesamiento.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Primero selecciona una imagen o enciende la cámara");
            }
        }
    }
}