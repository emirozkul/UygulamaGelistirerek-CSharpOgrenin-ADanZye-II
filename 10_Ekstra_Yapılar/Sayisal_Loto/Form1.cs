using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rstgl = new Random();

            sayi1 = rstgl.Next(1, 91);
            sayi2 = rstgl.Next(1, 91);
            sayi3 = rstgl.Next(1, 91);
            sayi4 = rstgl.Next(1, 91);
            sayi5 = rstgl.Next(1, 91);
            sayi6 = rstgl.Next(1, 91);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Stop();

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();

            if (label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.LightGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.LightGreen;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (label5.Text == textBox5.Text)
            {
                textBox5.BackColor = Color.LightGreen;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (label6.Text == textBox6.Text)
            {
                textBox6.BackColor = Color.LightGreen;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
        }
    }
}
