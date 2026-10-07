namespace application
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcb_fondo = new System.Windows.Forms.PictureBox();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.link_forgot_pwd = new System.Windows.Forms.LinkLabel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_pwd2 = new System.Windows.Forms.TextBox();
            this.lbl_pwd2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_apaterno = new System.Windows.Forms.TextBox();
            this.lbl_apaterno = new System.Windows.Forms.Label();
            this.txt_amaterno = new System.Windows.Forms.TextBox();
            this.lbl_amaterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_fondo
            // 
            this.pcb_fondo.Location = new System.Drawing.Point(1, 1);
            this.pcb_fondo.Name = "pcb_fondo";
            this.pcb_fondo.Size = new System.Drawing.Size(851, 735);
            this.pcb_fondo.TabIndex = 0;
            this.pcb_fondo.TabStop = false;
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_register.Location = new System.Drawing.Point(400, 627);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(50, 20);
            this.link_register.TabIndex = 8;
            this.link_register.TabStop = true;
            this.link_register.Text = "Login";
            this.link_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_register_LinkClicked);
            // 
            // link_forgot_pwd
            // 
            this.link_forgot_pwd.AutoSize = true;
            this.link_forgot_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_forgot_pwd.Location = new System.Drawing.Point(100, 409);
            this.link_forgot_pwd.Name = "link_forgot_pwd";
            this.link_forgot_pwd.Size = new System.Drawing.Size(0, 20);
            this.link_forgot_pwd.TabIndex = 14;
            this.link_forgot_pwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgot_pwd_LinkClicked);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Gray;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(359, 561);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(137, 49);
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.Text = "Guardar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(103, 451);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(286, 30);
            this.txt_pwd.TabIndex = 5;
            this.txt_pwd.UseSystemPasswordChar = true;
            this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(105, 338);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(286, 30);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(100, 411);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(120, 25);
            this.lbl_pwd.TabIndex = 10;
            this.lbl_pwd.Text = "Contraseña:";
            this.lbl_pwd.Click += new System.EventHandler(this.lbl_pwd_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(102, 301);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(90, 25);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario: ";
            this.lbl_usuario.Click += new System.EventHandler(this.lbl_usuario_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(358, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(155, 58);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "Registro";
            this.lbl_title.Click += new System.EventHandler(this.title_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(417, 338);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(329, 30);
            this.txt_correo.TabIndex = 4;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(412, 291);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(84, 25);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Correro:";
            this.lbl_email.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pwd2
            // 
            this.txt_pwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd2.Location = new System.Drawing.Point(460, 451);
            this.txt_pwd2.Name = "txt_pwd2";
            this.txt_pwd2.Size = new System.Drawing.Size(286, 30);
            this.txt_pwd2.TabIndex = 6;
            this.txt_pwd2.UseSystemPasswordChar = true;
            this.txt_pwd2.TextChanged += new System.EventHandler(this.txt_pwd2_TextChanged);
            // 
            // lbl_pwd2
            // 
            this.lbl_pwd2.AutoSize = true;
            this.lbl_pwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd2.Location = new System.Drawing.Point(457, 411);
            this.lbl_pwd2.Name = "lbl_pwd2";
            this.lbl_pwd2.Size = new System.Drawing.Size(205, 25);
            this.lbl_pwd2.TabIndex = 18;
            this.lbl_pwd2.Text = "Confirmar contraseña:";
            this.lbl_pwd2.Click += new System.EventHandler(this.lbl_pwd2_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(105, 229);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(217, 30);
            this.txt_nombre.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(102, 192);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(116, 25);
            this.lbl_nombre.TabIndex = 20;
            this.lbl_nombre.Text = "Nombre(s): ";
            // 
            // txt_apaterno
            // 
            this.txt_apaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apaterno.Location = new System.Drawing.Point(334, 229);
            this.txt_apaterno.Name = "txt_apaterno";
            this.txt_apaterno.Size = new System.Drawing.Size(200, 30);
            this.txt_apaterno.TabIndex = 1;
            this.txt_apaterno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_apaterno
            // 
            this.lbl_apaterno.AutoSize = true;
            this.lbl_apaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apaterno.Location = new System.Drawing.Point(329, 192);
            this.lbl_apaterno.Name = "lbl_apaterno";
            this.lbl_apaterno.Size = new System.Drawing.Size(104, 25);
            this.lbl_apaterno.TabIndex = 22;
            this.lbl_apaterno.Text = "A. Paterno";
            // 
            // txt_amaterno
            // 
            this.txt_amaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amaterno.Location = new System.Drawing.Point(546, 229);
            this.txt_amaterno.Name = "txt_amaterno";
            this.txt_amaterno.Size = new System.Drawing.Size(200, 30);
            this.txt_amaterno.TabIndex = 2;
            // 
            // lbl_amaterno
            // 
            this.lbl_amaterno.AutoSize = true;
            this.lbl_amaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amaterno.Location = new System.Drawing.Point(541, 192);
            this.lbl_amaterno.Name = "lbl_amaterno";
            this.lbl_amaterno.Size = new System.Drawing.Size(108, 25);
            this.lbl_amaterno.TabIndex = 24;
            this.lbl_amaterno.Text = "A. Materno";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 736);
            this.Controls.Add(this.txt_amaterno);
            this.Controls.Add(this.lbl_amaterno);
            this.Controls.Add(this.txt_apaterno);
            this.Controls.Add(this.lbl_apaterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_pwd2);
            this.Controls.Add(this.lbl_pwd2);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.link_forgot_pwd);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pcb_fondo);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_fondo;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.LinkLabel link_forgot_pwd;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_pwd2;
        private System.Windows.Forms.Label lbl_pwd2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_apaterno;
        private System.Windows.Forms.Label lbl_apaterno;
        private System.Windows.Forms.TextBox txt_amaterno;
        private System.Windows.Forms.Label lbl_amaterno;
    }
}