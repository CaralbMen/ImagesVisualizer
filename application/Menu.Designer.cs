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
            this.pcb_fondo = new System.Windows.Forms.PictureBox();
            this.pcb_Img = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_encender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(40, 35);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(51, 20);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "label1";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // pcb_fondo
            // 
            this.pcb_fondo.Location = new System.Drawing.Point(1, 0);
            this.pcb_fondo.Name = "pcb_fondo";
            this.pcb_fondo.Size = new System.Drawing.Size(847, 655);
            this.pcb_fondo.TabIndex = 1;
            this.pcb_fondo.TabStop = false;
            // 
            // pcb_Img
            // 
            this.pcb_Img.Location = new System.Drawing.Point(276, 67);
            this.pcb_Img.Name = "pcb_Img";
            this.pcb_Img.Size = new System.Drawing.Size(253, 196);
            this.pcb_Img.TabIndex = 2;
            this.pcb_Img.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Navy;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(328, 308);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(169, 40);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar Foto";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Navy;
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(328, 368);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(169, 40);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_encender
            // 
            this.btn_encender.BackColor = System.Drawing.Color.Navy;
            this.btn_encender.ForeColor = System.Drawing.Color.White;
            this.btn_encender.Location = new System.Drawing.Point(328, 434);
            this.btn_encender.Name = "btn_encender";
            this.btn_encender.Size = new System.Drawing.Size(169, 40);
            this.btn_encender.TabIndex = 5;
            this.btn_encender.Text = "Encender Camara";
            this.btn_encender.UseVisualStyleBackColor = false;
            this.btn_encender.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(328, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tomar Foto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 850);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_encender);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.pcb_Img);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pcb_fondo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pcb_fondo;
        private System.Windows.Forms.PictureBox pcb_Img;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_encender;
        private System.Windows.Forms.Button button1;
    }
}