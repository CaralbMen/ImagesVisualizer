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
            this.txt_apaterno = new System.Windows.Forms.TextBox();
            this.lbl_apaterno = new System.Windows.Forms.Label();
            this.txt_amaterno = new System.Windows.Forms.TextBox();
            this.lbl_amaterno = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.BackColor = System.Drawing.Color.Transparent;
            this.link_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_register.Location = new System.Drawing.Point(398, 906);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(60, 25);
            this.link_register.TabIndex = 8;
            this.link_register.TabStop = true;
            this.link_register.Text = "Login";
            this.link_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_register_LinkClicked);
            // 
            // link_forgot_pwd
            // 
            this.link_forgot_pwd.AutoSize = true;
            this.link_forgot_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_forgot_pwd.Location = new System.Drawing.Point(109, 511);
            this.link_forgot_pwd.Name = "link_forgot_pwd";
            this.link_forgot_pwd.Size = new System.Drawing.Size(0, 25);
            this.link_forgot_pwd.TabIndex = 14;
            this.link_forgot_pwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgot_pwd_LinkClicked);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Gray;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_entrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(356, 835);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(154, 61);
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.Text = "Guardar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(266, 671);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(375, 35);
            this.txt_pwd.TabIndex = 5;
            this.txt_pwd.UseSystemPasswordChar = true;
            this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(263, 475);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(375, 35);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(263, 632);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(123, 25);
            this.lbl_pwd.TabIndex = 10;
            this.lbl_pwd.Text = "Contraseña:";
            this.lbl_pwd.Click += new System.EventHandler(this.lbl_pwd_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(263, 446);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(101, 25);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario: ";
            this.lbl_usuario.Click += new System.EventHandler(this.lbl_usuario_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(343, 62);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(187, 58);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "Registro";
            this.lbl_title.Click += new System.EventHandler(this.title_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(263, 574);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(375, 35);
            this.txt_correo.TabIndex = 4;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(263, 529);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(89, 25);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Correro:";
            this.lbl_email.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pwd2
            // 
            this.txt_pwd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_pwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd2.Location = new System.Drawing.Point(266, 761);
            this.txt_pwd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pwd2.Name = "txt_pwd2";
            this.txt_pwd2.Size = new System.Drawing.Size(375, 35);
            this.txt_pwd2.TabIndex = 6;
            this.txt_pwd2.UseSystemPasswordChar = true;
            this.txt_pwd2.TextChanged += new System.EventHandler(this.txt_pwd2_TextChanged);
            // 
            // lbl_pwd2
            // 
            this.lbl_pwd2.AutoSize = true;
            this.lbl_pwd2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwd2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd2.Location = new System.Drawing.Point(261, 732);
            this.lbl_pwd2.Name = "lbl_pwd2";
            this.lbl_pwd2.Size = new System.Drawing.Size(227, 25);
            this.lbl_pwd2.TabIndex = 18;
            this.lbl_pwd2.Text = "Confirmar contraseña:";
            this.lbl_pwd2.Click += new System.EventHandler(this.lbl_pwd2_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(263, 189);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(375, 35);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_apaterno
            // 
            this.txt_apaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_apaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apaterno.Location = new System.Drawing.Point(263, 278);
            this.txt_apaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_apaterno.Name = "txt_apaterno";
            this.txt_apaterno.Size = new System.Drawing.Size(375, 35);
            this.txt_apaterno.TabIndex = 1;
            this.txt_apaterno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_apaterno
            // 
            this.lbl_apaterno.AutoSize = true;
            this.lbl_apaterno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apaterno.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apaterno.Location = new System.Drawing.Point(262, 249);
            this.lbl_apaterno.Name = "lbl_apaterno";
            this.lbl_apaterno.Size = new System.Drawing.Size(118, 25);
            this.lbl_apaterno.TabIndex = 22;
            this.lbl_apaterno.Text = "A. Paterno";
            // 
            // txt_amaterno
            // 
            this.txt_amaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_amaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amaterno.Location = new System.Drawing.Point(263, 388);
            this.txt_amaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_amaterno.Name = "txt_amaterno";
            this.txt_amaterno.Size = new System.Drawing.Size(375, 35);
            this.txt_amaterno.TabIndex = 2;
            // 
            // lbl_amaterno
            // 
            this.lbl_amaterno.AutoSize = true;
            this.lbl_amaterno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_amaterno.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amaterno.Location = new System.Drawing.Point(263, 346);
            this.lbl_amaterno.Name = "lbl_amaterno";
            this.lbl_amaterno.Size = new System.Drawing.Size(123, 25);
            this.lbl_amaterno.TabIndex = 24;
            this.lbl_amaterno.Text = "A. Materno";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(263, 160);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(117, 25);
            this.lblNom.TabIndex = 25;
            this.lblNom.Text = "Nombre(s):";
            this.lblNom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::application.Properties.Resources.background;
            this.groupBox2.Controls.Add(this.lblNom);
            this.groupBox2.Controls.Add(this.txt_amaterno);
            this.groupBox2.Controls.Add(this.lbl_amaterno);
            this.groupBox2.Controls.Add(this.txt_apaterno);
            this.groupBox2.Controls.Add(this.lbl_apaterno);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.txt_correo);
            this.groupBox2.Controls.Add(this.lbl_email);
            this.groupBox2.Controls.Add(this.link_forgot_pwd);
            this.groupBox2.Controls.Add(this.txt_usuario);
            this.groupBox2.Controls.Add(this.lbl_pwd);
            this.groupBox2.Controls.Add(this.lbl_usuario);
            this.groupBox2.Controls.Add(this.lbl_title);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 1025);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 1013);
            this.Controls.Add(this.txt_pwd2);
            this.Controls.Add(this.lbl_pwd2);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txt_apaterno;
        private System.Windows.Forms.Label lbl_apaterno;
        private System.Windows.Forms.TextBox txt_amaterno;
        private System.Windows.Forms.Label lbl_amaterno;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}