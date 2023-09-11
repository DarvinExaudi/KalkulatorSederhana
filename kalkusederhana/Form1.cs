using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkusederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Total;
        int num1;
        int num2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button7.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button0.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(TxtHasil.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            TxtHasil.Text = result + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = TxtHasil.Text + button9.Text;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(TxtHasil.Text);

            TxtHasil.Clear();
        }

        private void Min_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(TxtHasil.Text);

            TxtHasil.Clear();
        }

        private void Kali_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(TxtHasil.Text);

            TxtHasil.Clear();
        }

        private void Bagi_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(TxtHasil.Text);

            TxtHasil.Clear();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            TxtHasil.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
