using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle() 
        { 
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void doldur()
        {       
            textBox1.Text = "Emir";
            textBox2.Text = "Kaya";
            textBox3.Text = "öğrenci";
            textBox4.Text = "123456";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
