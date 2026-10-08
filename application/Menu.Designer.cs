namespace application
{
    partial class Menu
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_encender = new System.Windows.Forms.Button();
            this.btn_tomar_foto = new System.Windows.Forms.Button();
            this.pcb_Img = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_welcome.Location = new System.Drawing.Point(424, 90);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(73, 25);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Holaa";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Navy;
            this.btn_buscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(380, 530);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(249, 40);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar Foto";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Navy;
            this.btn_limpiar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(380, 651);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(249, 40);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_encender
            // 
            this.btn_encender.BackColor = System.Drawing.Color.Navy;
            this.btn_encender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encender.ForeColor = System.Drawing.Color.White;
            this.btn_encender.Location = new System.Drawing.Point(380, 586);
            this.btn_encender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_encender.Name = "btn_encender";
            this.btn_encender.Size = new System.Drawing.Size(249, 40);
            this.btn_encender.TabIndex = 5;
            this.btn_encender.Text = "Encender Camara";
            this.btn_encender.UseVisualStyleBackColor = false;
            this.btn_encender.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_tomar_foto
            // 
            this.btn_tomar_foto.BackColor = System.Drawing.Color.Navy;
            this.btn_tomar_foto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tomar_foto.ForeColor = System.Drawing.Color.White;
            this.btn_tomar_foto.Location = new System.Drawing.Point(380, 714);
            this.btn_tomar_foto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tomar_foto.Name = "btn_tomar_foto";
            this.btn_tomar_foto.Size = new System.Drawing.Size(249, 40);
            this.btn_tomar_foto.TabIndex = 6;
            this.btn_tomar_foto.Text = "Tomar Foto";
            this.btn_tomar_foto.UseVisualStyleBackColor = false;
            this.btn_tomar_foto.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // pcb_Img
            // 
            this.pcb_Img.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pcb_Img.Location = new System.Drawing.Point(273, 128);
            this.pcb_Img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_Img.Name = "pcb_Img";
            this.pcb_Img.Size = new System.Drawing.Size(477, 368);
            this.pcb_Img.TabIndex = 2;
            this.pcb_Img.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Navy;
            this.btn_guardar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(380, 780);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(249, 40);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(281, 34);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(549, 58);
            this.tittle.TabIndex = 8;
            this.tittle.Text = "Sistema de Visión Artificial";
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.Color.Navy;
            this.btn_procesar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesar.ForeColor = System.Drawing.Color.White;
            this.btn_procesar.Location = new System.Drawing.Point(380, 848);
            this.btn_procesar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(249, 40);
            this.btn_procesar.TabIndex = 9;
            this.btn_procesar.Text = "Procesar Imagen";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::application.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.tittle);
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 975);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 970);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_tomar_foto);
            this.Controls.Add(this.btn_encender);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.pcb_Img);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pcb_Img;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_encender;
        private System.Windows.Forms.Button btn_tomar_foto;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}