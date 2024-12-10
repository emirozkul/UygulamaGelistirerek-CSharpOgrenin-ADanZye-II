using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btn_Konum = new Point(50, 30);

            btn.Location = btn_Konum;
            btn.Name = "buton1";
            btn.Text = "Üret";
            btn.BackColor = Color.IndianRed;
            btn.Size = new Size(100, 50);

            Label lbl = new Label();

            Point lbl_Konum = new Point(250, 30);
            lbl.Location = lbl_Konum;
            lbl.Name = "label1";
            lbl.Text = "Dinamik Label";
            lbl.BackColor = Color.LightBlue;
            lbl.Size = new Size(100, 50);

            for (int i = 0; i <= 10; i++)
            {
                TextBox txt = new TextBox();
                txt.Location = new Point(750, 100 + (i * 45));
                txt.Name = "txt" + i;
                txt.Text = "Dinamik TextBox" + i;
                txt.Size = new Size(270, 50);
                this.Controls.Add(txt);
            }

            this.Controls.Add(lbl);
            this.Controls.Add(btn);

        }
    }
}
