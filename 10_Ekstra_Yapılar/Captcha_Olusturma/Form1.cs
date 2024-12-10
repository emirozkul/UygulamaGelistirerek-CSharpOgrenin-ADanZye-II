using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(null,null);
        }

        string[] sembol1 = { "a","b","c","d","e","f","g","h" };
        string[] sembol2 = { "A","B","C","D","E","F","G" };
        string[] sembol3 = { "!","#","$","%","/","-","_","=" };

        int sayi1, sayi2, sayi3, sayi4;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            if (label1.Text == textBox1.Text)
            {
                MessageBox.Show("Doğru girdiniz.","Eşleşme Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış girdiniz.", "Eşleşme Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            sayi1 = rnd.Next(0, sembol1.Length);
            sayi2 = rnd.Next(0, sembol2.Length);
            sayi3 = rnd.Next(0, sembol1.Length);
            sayi4 = rnd.Next(0, 10);

            label1.Text = sembol1[sayi1] + sembol2[sayi2] + sembol3[sayi3] + sayi4 ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            sayi1 = rnd.Next(0, sembol1.Length);
            sayi2 = rnd.Next(0, sembol2.Length);
            sayi3 = rnd.Next(0, sembol1.Length);
            sayi4 = rnd.Next(0, 10);

            label1.Text = sembol1[sayi1] + sembol2[sayi2] + sembol3[sayi3] + sayi4;
        }
    }
}
