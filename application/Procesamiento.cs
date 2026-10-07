using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application
{
    public partial class Procesamiento : Form
    {
        public string nombre, pathImage;
        public Procesamiento(string nombre, string pathImage)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.pathImage = pathImage;
            pcb_Img.Image = Image.FromFile(pathImage);
        }

        private void Procesamiento_Load(object sender, EventArgs e)
        {
            label1.Text = "Procesando imagen para: " + this.nombre;
            pcb_Img.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_separar_Click(object sender, EventArgs e)
        {
            // Ruta raíz del repo (sube dos niveles desde bin/Debug)
            string repoRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
     
            // Ejecutar script Python
            RunPythonScript(Path.Combine(repoRoot,@"..\python_scripts", "separar_capas.py"), this.pathImage);

            // Rutas de salida generadas por el script
            string ext = Path.GetExtension(this.pathImage);
            string basePath = this.pathImage.Substring(0, this.pathImage.Length - ext.Length);

            string redPath = basePath + "_red" + ext;
            string greenPath = basePath + "_green" + ext;
            string bluePath = basePath + "_blue" + ext;

            // Ocultar imagen original
            pcb_Img.Hide();

            PictureBox redBox = CreatePictureBox(redPath, new Point(37, 148));
            this.Controls.Add(redBox);
            redBox.BringToFront();

            PictureBox greenBox = CreatePictureBox(greenPath, new Point(210, 148));
            this.Controls.Add(greenBox);
            greenBox.BringToFront();

            PictureBox blueBox = CreatePictureBox(bluePath, new Point(390, 148));
            this.Controls.Add(blueBox);
            blueBox.BringToFront();
        }
        private PictureBox CreatePictureBox(string imagePath, Point location)
        {
            Image img = null;
            if (File.Exists(imagePath))
            {
                using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    img = Image.FromStream(stream);
                }
            }

            return new PictureBox
            {
                Size = new Size(150, 150),
                Location = location,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = img
            };
        }
        private void pcb_back_Click(object sender, EventArgs e)
        {

        }

        private void RunPythonScript(string scriptName, string args)
        { 
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                // Envolver argumentos entre comillas por si la ruta contiene espacios
                Arguments = $"\"{scriptName}\" \"{args}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true, // Capturar errores de ejecución
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
