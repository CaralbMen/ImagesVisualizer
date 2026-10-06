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
    }
}
