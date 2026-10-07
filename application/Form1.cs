using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form register = new Register();
            register.Show();
            this.Hide();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Ingresa tu nombre de usuario");
            }
            else if (txt_pwd.Text == "")
            {
                MessageBox.Show("Ingresa tu contraseña");
            }
            else
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        String query = "SELECT * FROM usuarios WHERE username = @username";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", txt_usuario.Text);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    String hashedPwd = reader.GetString("pwd");
                                    if (BCrypt.Net.BCrypt.Verify(txt_pwd.Text, hashedPwd))
                                    {
                                        Form menu = new Menu(txt_usuario.Text);
                                        menu.Show(); this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Contraseña incorrecta");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Usuario no encontrado");
                                }
                            }
                        }
                        //MessageBox.Show("Conexión exitosa a la base de datos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    }
                }
            }
        }
    }
}
