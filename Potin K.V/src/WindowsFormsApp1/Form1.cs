using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("about:blank");
                temp = openFileDialog1.FileName;
                webBrowser1.Navigate(temp);
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                toolStripStatusLabel1.Visible = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            if (((x - 1) * (x - 1) + y * y <= 4) || (y <= 3 - x) || (y >= x - 3))
            {
                toolStripStatusLabel1.Text = "Точка входит или на границе";
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(textBox3.Text);
            y = Convert.ToDouble(textBox4.Text);
            if ((y >= -1) || (y <= x) || (y <= 0) || (x * x + y * y <= 1))
            {
                toolStripStatusLabel1.Text = "Точка входит или на границе";
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }
    }
}
