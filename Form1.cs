using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        int b;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);

        }
      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            label2.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(textBox1.Text)  / int.Parse(textBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }


