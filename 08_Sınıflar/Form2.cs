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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba ww_15 = new Araba();

            ww_15.renk = "Beyaz";
            ww_15.hiz = 140;
            ww_15.motorHacmi = 1.5;
            ww_15.durum = 'S';
            ww_15.fiyat = 1500000;

            pictureBox1.BackColor = Color.Black;

            label1.Text = ww_15.renk;
            label2.Text = ww_15.hiz.ToString();
            label3.Text = ww_15.motorHacmi.ToString();
            label4.Text = ww_15.durum.ToString();
            label5.Text = ww_15.fiyat.ToString();

        }
    }
}
