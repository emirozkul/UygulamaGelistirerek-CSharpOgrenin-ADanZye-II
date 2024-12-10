using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poinr_Yapisi_Kullanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            panel1.Visible = false;
            label1.Visible = false;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int konumx = rnd.Next(0, this.Width);
            int konumy = rnd.Next(0, this.Height);

            Point p = new Point(konumx, konumy);

            button2.Location = p;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Visible = false;
            MessageBox.Show("Akşam Yemeği Hazır!","EVİN ADAMI", MessageBoxButtons.OK,MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
