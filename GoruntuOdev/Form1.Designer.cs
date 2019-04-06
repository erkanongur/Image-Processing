namespace GoruntuOdev
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gri_button = new System.Windows.Forms.Button();
            this.parlaklik = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.histogram = new System.Windows.Forms.Button();
            this.eski_hal = new System.Windows.Forms.Button();
            this.resim_sec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ters_cevir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(79, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gri_button
            // 
            this.gri_button.Location = new System.Drawing.Point(456, 37);
            this.gri_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gri_button.Name = "gri_button";
            this.gri_button.Size = new System.Drawing.Size(168, 28);
            this.gri_button.TabIndex = 1;
            this.gri_button.Text = "Gri Yap";
            this.gri_button.UseVisualStyleBackColor = true;
            this.gri_button.Click += new System.EventHandler(this.gri_button_Click);
            // 
            // parlaklik
            // 
            this.parlaklik.Location = new System.Drawing.Point(456, 135);
            this.parlaklik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parlaklik.Name = "parlaklik";
            this.parlaklik.Size = new System.Drawing.Size(168, 28);
            this.parlaklik.TabIndex = 2;
            this.parlaklik.Text = "Parlaklık Değiştir";
            this.parlaklik.UseVisualStyleBackColor = true;
            this.parlaklik.Click += new System.EventHandler(this.parlaklik_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 3;
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(456, 191);
            this.histogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(168, 28);
            this.histogram.TabIndex = 4;
            this.histogram.Text = "Histogram Eşitle";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // eski_hal
            // 
            this.eski_hal.Location = new System.Drawing.Point(243, 314);
            this.eski_hal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eski_hal.Name = "eski_hal";
            this.eski_hal.Size = new System.Drawing.Size(100, 28);
            this.eski_hal.TabIndex = 5;
            this.eski_hal.Text = "Sıfırla";
            this.eski_hal.UseVisualStyleBackColor = true;
            this.eski_hal.Click += new System.EventHandler(this.eski_hal_Click);
            // 
            // resim_sec
            // 
            this.resim_sec.Location = new System.Drawing.Point(79, 314);
            this.resim_sec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resim_sec.Name = "resim_sec";
            this.resim_sec.Size = new System.Drawing.Size(100, 28);
            this.resim_sec.TabIndex = 6;
            this.resim_sec.Text = "Resim Seç";
            this.resim_sec.UseVisualStyleBackColor = true;
            this.resim_sec.Click += new System.EventHandler(this.resim_sec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ters_cevir
            // 
            this.ters_cevir.Location = new System.Drawing.Point(456, 249);
            this.ters_cevir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ters_cevir.Name = "ters_cevir";
            this.ters_cevir.Size = new System.Drawing.Size(168, 28);
            this.ters_cevir.TabIndex = 7;
            this.ters_cevir.Text = "Ters Çevir";
            this.ters_cevir.UseVisualStyleBackColor = true;
            this.ters_cevir.Click += new System.EventHandler(this.ters_cevir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 382);
            this.Controls.Add(this.ters_cevir);
            this.Controls.Add(this.resim_sec);
            this.Controls.Add(this.eski_hal);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.parlaklik);
            this.Controls.Add(this.gri_button);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gri_button;
        private System.Windows.Forms.Button parlaklik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button eski_hal;
        private System.Windows.Forms.Button resim_sec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ters_cevir;
    }
}

