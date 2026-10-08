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
    public partial class Capas : Form
    {
        string basePath, ext;
        public Capas(string basePath, string ext)
        {
            InitializeComponent();
            this.basePath = basePath;
            this.ext = ext;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Capas_Load(object sender, EventArgs e)
        { 
            img_Cruda.Image = Image.FromFile(basePath + ext);
            img_Roja.Image = Image.FromFile(basePath + "_sred" + ext);
            img_Verde.Image = Image.FromFile(basePath + "_sgreen" + ext);
            img_Azul.Image = Image.FromFile(basePath + "_sblue" + ext);
            img_cian.Image = Image.FromFile(basePath + "_scyan" + ext);
            img_Magenta.Image = Image.FromFile(basePath + "_smagenta" + ext);
            img_yellow.Image = Image.FromFile(basePath + "_syellow" + ext);

        }
    }
}
