using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Motivational_quotes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        string path = @"C:\Users\dinui\source\repos\Motivational_quotes\Motivational_quotes\motivational.txt";

       
        private void label1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(path, textBox1.Text + "\n");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1(); ;
            f.Show();

        }
    }
}
