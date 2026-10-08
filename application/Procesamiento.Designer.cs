namespace application
{
    partial class Procesamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_back = new System.Windows.Forms.PictureBox();
            this.pcb_Img = new System.Windows.Forms.PictureBox();
            this.tittle2 = new System.Windows.Forms.TextBox();
            this.btn_separar = new System.Windows.Forms.Button();
            this.btn_gris = new System.Windows.Forms.Button();
            this.btn_hsv = new System.Windows.Forms.Button();
            this.btn_destacarRj = new System.Windows.Forms.Button();
            this.btn_destacarVr = new System.Windows.Forms.Button();
            this.btn_destacarAz = new System.Windows.Forms.Button();
            this.btn_negativa = new System.Windows.Forms.Button();
            this.btn_gamma = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.TrackBar();
            this.lbl_0 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcb_back
            // 
            this.pcb_back.Image = global::application.Properties.Resources.background;
            this.pcb_back.Location = new System.Drawing.Point(1, -6);
            this.pcb_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_back.Name = "pcb_back";
            this.pcb_back.Size = new System.Drawing.Size(822, 632);
            this.pcb_back.TabIndex = 1;
            this.pcb_back.TabStop = false;
            this.pcb_back.Click += new System.EventHandler(this.pcb_back_Click);
            // 
            // pcb_Img
            // 
            this.pcb_Img.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pcb_Img.Location = new System.Drawing.Point(189, 87);
            this.pcb_Img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_Img.Name = "pcb_Img";
            this.pcb_Img.Size = new System.Drawing.Size(424, 294);
            this.pcb_Img.TabIndex = 3;
            this.pcb_Img.TabStop = false;
            // 
            // tittle2
            // 
            this.tittle2.Location = new System.Drawing.Point(322, 10);
            this.tittle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tittle2.Name = "tittle2";
            this.tittle2.Size = new System.Drawing.Size(127, 22);
            this.tittle2.TabIndex = 4;
            this.tittle2.Text = "Procesamiento";
            // 
            // btn_separar
            // 
            this.btn_separar.BackColor = System.Drawing.Color.Navy;
            this.btn_separar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_separar.ForeColor = System.Drawing.Color.White;
            this.btn_separar.Location = new System.Drawing.Point(28, 397);
            this.btn_separar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_separar.Name = "btn_separar";
            this.btn_separar.Size = new System.Drawing.Size(221, 32);
            this.btn_separar.TabIndex = 5;
            this.btn_separar.Text = "Separar en Capas";
            this.btn_separar.UseVisualStyleBackColor = false;
            this.btn_separar.Click += new System.EventHandler(this.btn_separar_Click);
            // 
            // btn_gris
            // 
            this.btn_gris.BackColor = System.Drawing.Color.Navy;
            this.btn_gris.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gris.ForeColor = System.Drawing.Color.White;
            this.btn_gris.Location = new System.Drawing.Point(28, 458);
            this.btn_gris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gris.Name = "btn_gris";
            this.btn_gris.Size = new System.Drawing.Size(221, 32);
            this.btn_gris.TabIndex = 6;
            this.btn_gris.Text = "Gris";
            this.btn_gris.UseVisualStyleBackColor = false;
            this.btn_gris.Click += new System.EventHandler(this.btn_gris_Click);
            // 
            // btn_hsv
            // 
            this.btn_hsv.BackColor = System.Drawing.Color.Navy;
            this.btn_hsv.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hsv.ForeColor = System.Drawing.Color.White;
            this.btn_hsv.Location = new System.Drawing.Point(274, 397);
            this.btn_hsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hsv.Name = "btn_hsv";
            this.btn_hsv.Size = new System.Drawing.Size(221, 32);
            this.btn_hsv.TabIndex = 7;
            this.btn_hsv.Text = "HSV";
            this.btn_hsv.UseVisualStyleBackColor = false;
            this.btn_hsv.Click += new System.EventHandler(this.btn_hsv_Click);
            // 
            // btn_destacarRj
            // 
            this.btn_destacarRj.BackColor = System.Drawing.Color.Navy;
            this.btn_destacarRj.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_destacarRj.ForeColor = System.Drawing.Color.White;
            this.btn_destacarRj.Location = new System.Drawing.Point(274, 458);
            this.btn_destacarRj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_destacarRj.Name = "btn_destacarRj";
            this.btn_destacarRj.Size = new System.Drawing.Size(221, 32);
            this.btn_destacarRj.TabIndex = 8;
            this.btn_destacarRj.Text = "Destacar color rojo";
            this.btn_destacarRj.UseVisualStyleBackColor = false;
            this.btn_destacarRj.Click += new System.EventHandler(this.btn_destacarRj_Click);
            // 
            // btn_destacarVr
            // 
            this.btn_destacarVr.BackColor = System.Drawing.Color.Navy;
            this.btn_destacarVr.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_destacarVr.ForeColor = System.Drawing.Color.White;
            this.btn_destacarVr.Location = new System.Drawing.Point(511, 397);
            this.btn_destacarVr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_destacarVr.Name = "btn_destacarVr";
            this.btn_destacarVr.Size = new System.Drawing.Size(221, 32);
            this.btn_destacarVr.TabIndex = 9;
            this.btn_destacarVr.Text = "Destacar color verde";
            this.btn_destacarVr.UseVisualStyleBackColor = false;
            this.btn_destacarVr.Click += new System.EventHandler(this.btn_destacarVr_Click);
            // 
            // btn_destacarAz
            // 
            this.btn_destacarAz.BackColor = System.Drawing.Color.Navy;
            this.btn_destacarAz.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_destacarAz.ForeColor = System.Drawing.Color.White;
            this.btn_destacarAz.Location = new System.Drawing.Point(511, 458);
            this.btn_destacarAz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_destacarAz.Name = "btn_destacarAz";
            this.btn_destacarAz.Size = new System.Drawing.Size(221, 32);
            this.btn_destacarAz.TabIndex = 10;
            this.btn_destacarAz.Text = "Destacar color azul";
            this.btn_destacarAz.UseVisualStyleBackColor = false;
            this.btn_destacarAz.Click += new System.EventHandler(this.btn_destacarAz_Click);
            // 
            // btn_negativa
            // 
            this.btn_negativa.BackColor = System.Drawing.Color.Navy;
            this.btn_negativa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_negativa.ForeColor = System.Drawing.Color.White;
            this.btn_negativa.Location = new System.Drawing.Point(28, 514);
            this.btn_negativa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_negativa.Name = "btn_negativa";
            this.btn_negativa.Size = new System.Drawing.Size(221, 32);
            this.btn_negativa.TabIndex = 11;
            this.btn_negativa.Text = "Negativa";
            this.btn_negativa.UseVisualStyleBackColor = false;
            this.btn_negativa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gamma
            // 
            this.btn_gamma.BackColor = System.Drawing.Color.Navy;
            this.btn_gamma.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gamma.ForeColor = System.Drawing.Color.White;
            this.btn_gamma.Location = new System.Drawing.Point(274, 514);
            this.btn_gamma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gamma.Name = "btn_gamma";
            this.btn_gamma.Size = new System.Drawing.Size(221, 32);
            this.btn_gamma.TabIndex = 12;
            this.btn_gamma.Text = "Gamma";
            this.btn_gamma.UseVisualStyleBackColor = false;
            this.btn_gamma.Click += new System.EventHandler(this.btn_gamma_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Navy;
            this.btn_guardar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(511, 514);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(221, 32);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // level1
            // 
            this.level1.Location = new System.Drawing.Point(345, 505);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(104, 56);
            this.level1.TabIndex = 14;
            this.level1.Value = 3;
            this.level1.Visible = false;
            this.level1.Scroll += new System.EventHandler(this.level1_Scroll);
            // 
            // lbl_0
            // 
            this.lbl_0.Location = new System.Drawing.Point(347, 530);
            this.lbl_0.Name = "lbl_0";
            this.lbl_0.Size = new System.Drawing.Size(31, 38);
            this.lbl_0.TabIndex = 15;
            this.lbl_0.Text = "0";
            this.lbl_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_0.Visible = false;
            // 
            // lbl_1
            // 
            this.lbl_1.Location = new System.Drawing.Point(384, 534);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(25, 30);
            this.lbl_1.TabIndex = 16;
            this.lbl_1.Text = "1";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_1.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.Location = new System.Drawing.Point(417, 530);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(31, 38);
            this.lbl_2.TabIndex = 17;
            this.lbl_2.Text = "2";
            this.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_2.Visible = false;
            // 
            // Procesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 628);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_0);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_gamma);
            this.Controls.Add(this.btn_negativa);
            this.Controls.Add(this.btn_destacarAz);
            this.Controls.Add(this.btn_destacarVr);
            this.Controls.Add(this.btn_destacarRj);
            this.Controls.Add(this.btn_hsv);
            this.Controls.Add(this.btn_gris);
            this.Controls.Add(this.btn_separar);
            this.Controls.Add(this.tittle2);
            this.Controls.Add(this.pcb_Img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Procesamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento";
            this.Load += new System.EventHandler(this.Procesamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_back;
        private System.Windows.Forms.PictureBox pcb_Img;
        private System.Windows.Forms.TextBox tittle2;
        private System.Windows.Forms.Button btn_separar;
        private System.Windows.Forms.Button btn_gris;
        private System.Windows.Forms.Button btn_hsv;
        private System.Windows.Forms.Button btn_destacarRj;
        private System.Windows.Forms.Button btn_destacarVr;
        private System.Windows.Forms.Button btn_destacarAz;
        private System.Windows.Forms.Button btn_negativa;
        private System.Windows.Forms.Button btn_gamma;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TrackBar level1;
        private System.Windows.Forms.Label lbl_0;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
    }
}