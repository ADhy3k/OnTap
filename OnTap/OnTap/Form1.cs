using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            textBox3.Text = t.ToString();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBox3.Text = t.ToString();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            textBox3.Text = t.ToString();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            textBox3.Text = t.ToString();
            Show();
        }
    }
}
