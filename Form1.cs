using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChmodHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int getPermBit(int bit, CheckBox id)
        {
            int ret = (id.Checked) ? (1 << bit) : 0;
            return ret;
        }

        private string Calculate()
        {
            int perms = getPermBit(8, cb8) | getPermBit(7, cb7) | getPermBit(6, cb6)
                    | getPermBit(5, cb5) | getPermBit(4, cb4) | getPermBit(3, cb3)
                    | getPermBit(2, cb2) | getPermBit(1, cb1) | getPermBit(0, cb0);
            return "chmod " + Convert.ToString(perms, 8);
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void cb0_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Calculate();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") Clipboard.SetDataObject(textBox1.Text);
        }
    }
}
