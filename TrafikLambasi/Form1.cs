using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambasi
{
    public partial class Form1 : Form
    {
        int sn = 80;
        int t = 1;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            button4.Text = sn.ToString();
            if (sn>0 && sn<40)
            {
                t = 3;
            }
            if (sn > 40 && sn < 45)
            {
                t = 2;
            }
            if (sn > 45 && sn < 80)
            {
                t = 1;
            }
            if (sn <=0)
            {
                sn = 80;
            }
            if (t==1)
            {
                sn--;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
            }
            if (t == 2)
            {
                sn--;
                button1.BackColor = Color.White;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.White;
            }
            if (t == 3)
            {
                sn--;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.Green;
            }
        }
    }
}
