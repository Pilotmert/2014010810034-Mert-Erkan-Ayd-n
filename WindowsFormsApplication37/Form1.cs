using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication37
{
    public partial class IlkCalısma : Form
    {
        Bitmap kaynak, islem;
        public IlkCalısma()
        {
            InitializeComponent();
        }

        private void resimSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                pencere1.Image = kaynak;
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int b = 0; b < yuk; b++)
            {
                for (int a = 0; a < gen; a++)
                {
                    Color renkliRenk = kaynak.GetPixel(a, b);
                    int gri = (int)((double)(renkliRenk.R * 0.2125) + (double)(renkliRenk.G * 0.7154) + (double)(renkliRenk.B * 0.072));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(a, b, griRenk);


                }

                pencere2.Image = islem;

            }
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int b = 0; b < yuk; b++)
            {
                for (int a = 0; a < gen; a++)
                {
                    Color renkliRenk = kaynak.GetPixel(a, b);
                    int gri = (int)(double)((renkliRenk.R * 0.3) + (renkliRenk.G * 0.59) + (renkliRenk.B * 0.11));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(a, b, griRenk);


                }

                pencere2.Image = islem;
            }
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int b = 0; b < yuk; b++)
            {
                for (int a = 0; a < gen; a++)
                {
                    Color renkliRenk = kaynak.GetPixel(a, b);
                    int gri = Math.Max(renkliRenk.B, (Math.Max(renkliRenk.R, renkliRenk.G)) + Math.Min(renkliRenk.B, Math.Min(renkliRenk.R, renkliRenk.G))) / 2;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(a, b, griRenk);


                }

                pencere2.Image = islem;
            }
        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int b = 0; b < yuk; b++)
            {
                for (int a = 0; a < gen; a++)
                {
                    Color renkliRenk = kaynak.GetPixel(a, b);
                    int Yenigri = (renkliRenk.R | renkliRenk.G | renkliRenk.B);
                    Color griRenk = Color.FromArgb(Yenigri, Yenigri, Yenigri);
                    islem.SetPixel(a, b, griRenk);


                }

                pencere2.Image = islem;
            }
          
        }
    }
}
