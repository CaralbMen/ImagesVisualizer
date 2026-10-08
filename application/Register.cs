using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace application
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void link_forgot_pwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txt_nombre.Text != "")
            {
                if(txt_apaterno.Text!="")
                {
                    if(txt_amaterno.Text != "")
                    {
                        if (txt_usuario.Text != "")
                        {
                            if (txt_pwd.Text != "")
                            {
                                if (txt_pwd2.Text != "")
                                {
                                    if (txt_pwd.Text == txt_pwd2.Text)
                                    {
                                        if (txt_correo.Text != "")
                                        {
                                            if (txt_correo.Text.Contains("@") && txt_correo.Text.Contains("."))
                                            {
                                                using (MySqlConnection connection = Connection.GetConnection())
                                                {
                                                    try
                                                    {
                                                        long newId = 0;
                                                        connection.Open();
                                                        String hashedPwd = BCrypt.Net.BCrypt.HashPassword(txt_pwd.Text);
                                                        string query = "INSERT INTO usuarios (nombre, apaterno, amaterno, username, email, pwd) VALUES (@nombre, @apaterno, @amaterno, @username, @email, @password)";
                                                        using (MySqlCommand command = new MySqlCommand(query, connection))
                                                        {
                                                            command.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                                                            command.Parameters.AddWithValue("@apaterno", txt_apaterno.Text);
                                                            command.Parameters.AddWithValue("@amaterno", txt_amaterno.Text);
                                                            command.Parameters.AddWithValue("@username", txt_usuario.Text);
                                                            command.Parameters.AddWithValue("@email", txt_correo.Text);
                                                            command.Parameters.AddWithValue("@password", hashedPwd);
                                                            command.ExecuteNonQuery();
                                                            newId = command.LastInsertedId;
                                                        }
                                                        MessageBox.Show("Usuario registrado exitosamente");
                                                        Form menu = new Menu(txt_usuario.Text, newId);
                                                        menu.Show();
                                                        this.Close();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingresa un correo electrónico válido");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingresa tu correo electrónico");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Las contraseñas no coinciden");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Confirma tu contraseña");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingresa tu contraseña");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresa tu nombre de usuario");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa tu apellido paterno");
                }
            }else
            {
                MessageBox.Show("Ingresa tu nombre");
            }
            //if(txt_usuario.Text != "")
            //{
            //    if(txt_pwd.Text != "")
            //    {
            //        if(txt_pwd2.Text!= "")
            //        {
            //            if (txt_pwd.Text == txt_pwd2.Text)
            //            {
            //                if (txt_correo.Text != "")
            //                {
            //                    if(txt_correo.Text.Contains("@") && txt_correo.Text.Contains("."))
            //                    {
            //                        using (MySqlConnection connection = Connection.GetConnection())
            //                        {
            //                            try
            //                            {
            //                                connection.Open();
            //                                String hashedPwd = BCrypt.Net.BCrypt.HashPassword(txt_pwd.Text);
            //                                string query = "INSERT INTO usuarios (username, pwd, email) VALUES (@username, @password, @email)";
            //                                using (MySqlCommand command = new MySqlCommand(query, connection))
            //                                {
            //                                    command.Parameters.AddWithValue("@username", txt_usuario.Text);
            //                                    command.Parameters.AddWithValue("@password", hashedPwd);
            //                                    command.Parameters.AddWithValue("@email", txt_correo.Text);
            //                                    command.ExecuteNonQuery();
            //                                }
            //                                MessageBox.Show("Usuario registrado exitosamente");
            //                                Form menu = new Menu(txt_usuario.Text);
            //                                menu.Show();
            //                                this.Close();
            //                            }
            //                            catch (Exception ex)
            //                            {
            //                                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            //                            }
            //                        }
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Ingresa un correo electrónico válido");
            //                    }
                                
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Ingresa tu correo electrónico");
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Las contraseñas no coinciden");
            //            }
            //        } else
            //        {
            //            MessageBox.Show("Confirma tu contraseña");
            //        }

            //    }else
            //    {
            //        MessageBox.Show("Ingresa tu contraseña");
            //    }

            //}else
            //{
            //    MessageBox.Show("Ingresa tu nombre de usuario");
            //}
        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pwd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pwd2_Click(object sender, EventArgs e)
        {

        }

        private void txt_pwd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
