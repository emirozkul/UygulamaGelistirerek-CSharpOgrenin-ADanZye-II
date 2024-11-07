using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Sınıflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba ww_16 = new Araba();

            ww_16.renk = "Beyaz";
            ww_16.hiz = 240;
            ww_16.motorHacmi = 1.6;
            ww_16.durum = 'S';
            ww_16.fiyat = 2000000;
            ww_16.YIL = -2016;
            ww_16.MARKASI = "beetle";
            ww_16.plaka = "34 ABC 34";
            ww_16.muayne = 2018;
            ww_16.sahip = "Ali";

            label1.Text = ww_16.renk;
            label2.Text = ww_16.hiz.ToString();
            label3.Text = ww_16.motorHacmi.ToString();
            label4.Text = ww_16.durum.ToString();
            label5.Text = ww_16.fiyat.ToString();
            label6.Text = ww_16.YIL.ToString();
            label7.Text = ww_16.MARKASI;
            label8.Text = ww_16.plaka;
            label9.Text = ww_16.muayne.ToString();
            label10.Text = ww_16.sahip;

            pictureBox1.BackColor = Color.Beige;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
