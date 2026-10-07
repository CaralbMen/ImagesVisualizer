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
    public partial class Procesamiento : Form
    {
        public string nombre;
        public Procesamiento(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void Procesamiento_Load(object sender, EventArgs e)
        {
            label1.Text = "Procesando imagen para: " + this.nombre;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
