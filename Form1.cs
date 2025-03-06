using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnalmod3_103022330124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tambah, tambah1, tambah2;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '+';
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] angka = textBox1.Text.Split('+');
            tambah = Int32.Parse(angka[0]);
            tambah1 = Int32.Parse(angka[1]);

            int hasil = tambah + tambah1;

            if(angka.Length > 2)
            {
                tambah2 = Int32.Parse(angka[2]);
                hasil += tambah2;
            }

            textBox1.Text = hasil   .ToString();

        }
    }
}
