using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = userInput.Text;
            int len = Lab1ClassLibrary1.Fib.Len(input);
            int fib = Lab1ClassLibrary1.Fib.FibonacciLength(input);
            string output = "Довжина рядка N: " + len;
            if (fib == -1)
            {
                output += " не є числом Фібоначчі.";
            }
            else
            {
                output += " є числом Фібоначчі номер " + fib;
            }
            outputBox.Text = output;
        }
    }
}
