using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilkProjemHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2;

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            int sonuc = s1 - s2;
            lblSonuc.Text = sonuc.ToString();
            lblSonuc.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            int sonuc = s1 * s2;
            lblSonuc.Text = sonuc.ToString();
            lblSonuc.BackColor = Color.LightGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2;
            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            double sonuc = s1 / s2;
            lblSonuc.Text = sonuc.ToString();
            lblSonuc.BackColor = Color.LightGray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 1;

            if (txt1.Text != "")
            {
                int girilenSayi = Convert.ToInt32(txt1.Text);
                for (int i = 1; i < girilenSayi; i++)
                {
                    toplam += toplam * i;
                }
            }
            else
            {
                int girilenSayi = Convert.ToInt32(txt2.Text);
                for (int i = 1; i < girilenSayi; i++)
                {
                    toplam += toplam * i;
                }
            }

            lblSonuc.Text = toplam.ToString();
            lblSonuc.BackColor = Color.LightGray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double s1, s2;
            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            double sonuc = Math.Pow(s1, s2);
            lblSonuc.Text = sonuc.ToString();
            lblSonuc.BackColor = Color.LightGray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgeleSayi;
            rastgeleSayi = rnd.Next(0, 100);
            lblSonuc.Text = rastgeleSayi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[8] { Color.Red, Color.Blue, Color.Black, Color.Brown, Color.Purple, Color.LightSalmon, Color.Pink, Color.Yellow };
            Random rnd = new Random();
            int dizi_elemani = rnd.Next(0, 7);
            this.BackColor = renkler[dizi_elemani];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            txt1.Clear();
            txt2.Text = "";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            int sonuc = s1 + s2;
            lblSonuc.Text = sonuc.ToString();
            lblSonuc.BackColor = Color.LightGray;
        }
    }
}
