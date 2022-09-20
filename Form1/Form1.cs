using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            txtrta.Text = (Int32.Parse(txtop1.Text) + Int32.Parse(txtop2.Text)).ToString();
        }

        private void txtop2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            txtrta.Text = Convert.ToString(Convert.ToInt32(txtop1.Text) - Convert.ToInt32(txtop2.Text));
        }

        private void Btncoc_Click(object sender, EventArgs e)
        {
            txtrta.Text = (Int32.Parse(txtop1.Text) / Int32.Parse(txtop2.Text)).ToString()
        }

        private void Btnprod_Click(object sender, EventArgs e)
        {
            txtrta.Text = (Int32.Parse(txtop1.Text) * Int32.Parse(txtop2.Text)).ToString();
        }
    }
}
