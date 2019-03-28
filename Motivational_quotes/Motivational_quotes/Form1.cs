using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motivational_quotes
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\dinui\source\repos\Motivational_quotes\Motivational_quotes\motivational.txt";
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            
            string[] lines = System.IO.File.ReadAllLines(path);
            textBox1.Text = lines[rnd.Next(1, 13)];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void inregistreazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Size sz = new Size(textBox1.ClientSize.Width, int.MaxValue);
            TextFormatFlags flags = TextFormatFlags.WordBreak;
            int padding = 3;
            int borders = textBox1.Height - textBox1.ClientSize.Height;
            sz = TextRenderer.MeasureText(textBox1.Text, textBox1.Font, sz, flags);
            int h = sz.Height + borders + padding;
            if (textBox1.Top + h > this.ClientSize.Height - 10)
            {
                h = this.ClientSize.Height - 10 - textBox1.Top;
            }
            textBox1.Height = h;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] lines = System.IO.File.ReadAllLines(path);
            textBox1.Text = lines[rnd.Next(1, 13)];
        }
    }
}
