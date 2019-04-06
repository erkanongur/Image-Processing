using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //
        //Değişkenler
        //
        Bitmap degisen_resim;
        Bitmap degismeyen_resim;
        bool a = true;
        //
        //Butonlar
        //
        private void resim_sec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files | *.*";
            dialog.Title = "Bir resim dosyası seçiniz";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = dialog.FileName;
            a = true;
        }

        private void gri_button_Click(object sender, EventArgs e)
        {
            degisen_resim = new Bitmap(pictureBox1.Image);
            if (a)
            {
                degismeyen_resim = new Bitmap(pictureBox1.Image);
                a = false;
            }
            Gri_Yap(degisen_resim);
            pictureBox1.Image = degisen_resim;
        }
        private void histogram_Click(object sender, EventArgs e)
        {
            if (a)
            {
                degismeyen_resim = new Bitmap(pictureBox1.Image);
                a = false;
            }
            degisen_resim = new Bitmap(pictureBox1.Image);
            Histogram_Esitle(degisen_resim);
            pictureBox1.Image = degisen_resim;
        }
        private void parlaklik_Click(object sender, EventArgs e)
        {
            if (a)
            {
                degismeyen_resim = new Bitmap(pictureBox1.Image);
                a = false;
            }
            degisen_resim = new Bitmap(pictureBox1.Image);
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            int parlat = Convert.ToInt32(textBox1.Text);
            parlaklik_Ayarla(degisen_resim, parlat);
            pictureBox1.Image = degisen_resim;
        }
        private void ters_cevir_Click(object sender, EventArgs e)
        {
            if (a)
            {
                degismeyen_resim = new Bitmap(pictureBox1.Image);
                a = false;
            }
            degisen_resim = new Bitmap(pictureBox1.Image);
            ters_dondur(degisen_resim);
            pictureBox1.Image = degisen_resim;
        }
        private void eski_hal_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = degismeyen_resim;
        }
        //
        //Fonksiyonlar
        //
        private Bitmap Gri_Yap(Bitmap image)
        {
            for(int i = 0; i < image.Height-1; i++)
            {
                for (int j = 0; j < image.Width-1; j++)
                {
                    int gri_deger = (image.GetPixel(j, i).R + image.GetPixel(j, i).G + image.GetPixel(j, i).B) / 3;

                    Color renk = Color.FromArgb(gri_deger, gri_deger, gri_deger);
                    image.SetPixel(j, i, renk);
                }
            }
            return image;
        }
        private Bitmap Histogram_Esitle(Bitmap image)
        {
            uint pixels = (uint)image.Height * (uint)image.Width;

            decimal Const = 255 / (decimal)pixels;



            int x, y, R, G, B;


            int[] HistogramRed2 = new int[256];
            int[] HistogramGreen2 = new int[256];
            int[] HistogramBlue2 = new int[256];


            for (var i = 0; i < image.Width; i++)
            {
                for (var j = 0; j < image.Height; j++)
                {
                    var piksel = image.GetPixel(i, j);

                    HistogramRed2[(int)piksel.R]++;
                    HistogramGreen2[(int)piksel.G]++;
                    HistogramBlue2[(int)piksel.B]++;

                }
            }

            int[] cdfR = HistogramRed2;
            int[] cdfG = HistogramGreen2;
            int[] cdfB = HistogramBlue2;

            for (int r = 1; r <= 255; r++)
            {
                cdfR[r] = cdfR[r] + cdfR[r - 1];
                cdfG[r] = cdfG[r] + cdfG[r - 1];
                cdfB[r] = cdfB[r] + cdfB[r - 1];
            }

            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    R = (int)((decimal)cdfR[pixelColor.R] * Const);
                    G = (int)((decimal)cdfG[pixelColor.G] * Const);
                    B = (int)((decimal)cdfB[pixelColor.B] * Const);

                    Color newColor = Color.FromArgb(R, G, B);
                    image.SetPixel(x, y, newColor);
                }
            }
            return image;
        }

        
        private Bitmap parlaklik_Ayarla(Bitmap image, int parlat)
        {
            for (int i = 0; i < image.Height - 1; i++)
            {
                for (int j = 0; j < image.Width - 1; j++)
                {
                    int deger_red = image.GetPixel(j, i).R + parlat;
                    int deger_green = image.GetPixel(j, i).G + parlat;
                    int deger_blue = image.GetPixel(j, i).B + parlat;

                    if (deger_red > 255) deger_red = 255;
                    if (deger_red < 0) deger_red = 0;
                    if (deger_green > 255) deger_green = 255;
                    if (deger_green < 0) deger_green = 0;
                    if (deger_blue > 255) deger_blue = 255;
                    if (deger_blue < 0) deger_blue = 0;

                    Color renk = Color.FromArgb(deger_red, deger_green, deger_blue);
                    image.SetPixel(j, i, renk);
                }
            }
            return image;
        }
        private void ters_dondur(Bitmap image)
        {
            degisen_resim = new Bitmap(pictureBox1.Image);
            Color[][] tersle = new Color[degisen_resim.Width][];
            for (int i = 0; i < degisen_resim.Width; i++)
            {
                tersle[i] = new Color[degisen_resim.Height];
                for (int j = 0; j < degisen_resim.Height; j++)
                {
                    tersle[i][j] = degisen_resim.GetPixel(i, j);
                }
            }
            for (int i = 0; i < degisen_resim.Width; i++)
            {
                for (int j = 0; j < degisen_resim.Height; j++)
                {
                    degisen_resim.SetPixel(i, j, tersle[degisen_resim.Width - i - 1][degisen_resim.Height - j - 1]);
                }
            }
        }
    }
}
