using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double i = Convert.ToDouble(textBox2.Text);
            textBox3.Text = "Результаты работы программы " +
            "ст. Петрова И.И. " +
            Environment.NewLine;
            textBox3.Text += "При X = " + textBox1.Text +

            Environment.NewLine;

            textBox3.Text += "При I = " + textBox2.Text +

            Environment.NewLine;

            double t;
            
            if (i % 2 == 1 && x > 0)
            t = i * Math.Sqrt(x);
            if (i % 2 == 0 && x < 0)
            t = i / (2 * Math.Sqrt(Math.Abs(x)));
            else
            t = Math.Sqrt(Math.Abs(i * x));
            textBox3.Text += "t = " + t.ToString() +
            Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
