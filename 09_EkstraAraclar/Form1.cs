using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace _09_EkstraAraclar
{
    public partial class Form1 : Form
    {
        private WebView2 webView; // WebView2 kontrolünü sınıf seviyesinde tanımlıyoruz

        public Form1()
        {
            InitializeComponent();

            
            webView = new WebView2
            {
                Dock = DockStyle.Fill, 
                Source = new Uri("https://www.youtube.com") 
            };

            panel1.Controls.Add(webView); 

            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Emir Özkul tarafından yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Mad Max - Fury Road";
            webView.Source = new Uri("https://www.youtube.com/watch?v=hEJnMQG9ev8");

        }

        private void aboutTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "About Time";
            webView.Source = new Uri("https://www.youtube.com/watch?v=T7A810duHvw");
        }

        private void testereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Saw";
            webView.Source = new Uri("https://www.youtube.com/watch?v=S-1QgOMQ-ls");
        }

        private void yıldızlararasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Yıldızlararası";
            webView.Source = new Uri("https://www.youtube.com/watch?v=vVJeYMRam0o");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
