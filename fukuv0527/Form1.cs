using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0527
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 12;
            label2.Top = label2.Top + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 12;
            label2.Left = label2.Left + 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 12;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 12;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
