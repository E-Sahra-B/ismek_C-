using System;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        int salise =0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            salise++;
            if (salise==100)
            {
                salise = 0;
                saniye++;
            }
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
        }
    }
}