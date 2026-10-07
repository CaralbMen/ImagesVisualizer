using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application
{
    public partial class Menu : Form
    {
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

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
