using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace application
{
    public partial class Procesamiento : Form
    {
        public string nombre, pathImage, repoRoot;
        public long id_usuario;

        public Procesamiento(string nombre, string pathImage, long id_usuario)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.pathImage = pathImage;
            this.id_usuario = id_usuario;
            this.repoRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            pcb_Img.Image = Image.FromFile(pathImage);
        }

        private void Procesamiento_Load(object sender, EventArgs e)
        {
            label1.Text = "Procesando imagen para: " + this.nombre;
            pcb_Img.SizeMode = PictureBoxSizeMode.StretchImage;
            show_gammaBar(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            processImage("negativa", "negativa");
        }

        private void btn_separar_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            
         
            RunPythonScript(Path.Combine(this.repoRoot,"python_scripts", "separar_capas.py"), this.pathImage);
            pcb_Img.Image = Image.FromFile(this.pathImage);

            // Rutas de salida generadas por el script
            string ext = Path.GetExtension(this.pathImage);
            string basePath = this.pathImage.Substring(0, this.pathImage.Length - ext.Length);

            Form capas = new Capas(basePath, ext);
            capas.Show();
        }
      
        private void pcb_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_destacarAz_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            pcb_Img.Image = Image.FromFile(this.pathImage);
            processImage("capa_azul", "blue");
        }

        private void btn_destacarRj_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            pcb_Img.Image = Image.FromFile(this.pathImage);
            processImage("capa_roja", "red");
        }

        private void btn_destacarVr_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            pcb_Img.Image = Image.FromFile(this.pathImage);
            processImage("capa_verde", "green");
        }

        private void btn_gris_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            pcb_Img.Image = Image.FromFile(this.pathImage);
            processImage("grises", "gray");
        }

        private void btn_hsv_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            pcb_Img.Image = Image.FromFile(this.pathImage);
            processImage("hsv", "hsv");
        }
        private void show_gammaBar(bool show)
        {
            btn_gamma.Visible = !show;
            level1.Visible = show;
            lbl_0.Visible = show;
            lbl_1.Visible = show;
            lbl_2.Visible = show;
        }
        private void btn_gamma_Click(object sender, EventArgs e)
        {
            
            show_gammaBar(true);
            //processImage("gamma", "gamma0", 0);
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
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            show_gammaBar(false);
            Bitmap bmp = new Bitmap(pcb_Img.Image);
            int[,,] rgbMatrix = GetRGBMatrix(bmp);

            string jsonMatrix = JsonConvert.SerializeObject(rgbMatrix);

            using (MySqlConnection conn = Connection.GetConnection())
            {
                try
                {

                    conn.Open();
                    string query = "INSERT INTO imagenes (id_usuario, imagen) VALUES (@usuario_id, @imagen_data)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario_id", this.id_usuario);
                        cmd.Parameters.AddWithValue("@imagen_data", jsonMatrix);
                        cmd.ExecuteNonQuery();
                        long imagenId = cmd.LastInsertedId;
                    }
                    MessageBox.Show("Imagen guardada en la base de datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(jsonMatrix);
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);

                }
            }
               
        }

        private void level1_Scroll(object sender, EventArgs e)
        {
            if(level1.Value == 0)
            {
                processImage("gamma", "gamma0", 0);
            }else if(level1.Value== 5)
            {
                processImage("gamma", "gamma1", 1);
            }
            else if(level1.Value == 10)
            {
                processImage("gamma", "gamma2", 2);
            }
            else
            {
                pcb_Img.Image = Image.FromFile(this.pathImage);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form menu = new Menu(this.nombre, this.id_usuario);
            menu.Show();
        }

        private void processImage(string file, string extension, double level = 0)
        {
            // Ejecutar script Python
            RunPythonScript(Path.Combine(this.repoRoot, "python_scripts", file+ ".py"), this.pathImage, level);

            // Rutas de salida generadas por el script se saca la extencion del archivo y se le agrega el _red, blue o green dependiendo del procesamiento
            string ext = Path.GetExtension(this.pathImage);
            string basePath = this.pathImage.Substring(0, this.pathImage.Length - ext.Length);
            // documents/image_gray.jpeg

            string imgPath = basePath + "_"+ extension + ext;
            pcb_Img.Image = Image.FromFile(imgPath);
        }

        private void RunPythonScript(string scriptName, string args, double level = 0)
        {
            pcb_Img.Image = null;
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                //  argumentos entre comillas por si la ruta contiene espacios
                Arguments = $"\"{scriptName}\" \"{args}\" {level}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Error en script Python:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(output, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
