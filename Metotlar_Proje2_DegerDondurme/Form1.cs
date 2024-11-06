using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_Proje2_DegerDondurme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int carpim(int s1, int s2)
        { 
            int sonuc = s1 * s2;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = carpim(5, 3).ToString();
            label2.Text = carpim(7, 8).ToString();
            label3.Text = carpim(9, 4).ToString();
        }
    }
}
