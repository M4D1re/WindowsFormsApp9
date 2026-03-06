using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        double digit1;
        string znak;
        public Form1()
        {
            InitializeComponent();
        }
        private void digit_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            txtDisplay.Text = txtDisplay.Text += button.Text;
        }
        private void znak_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            digit1 = Convert.ToDouble(txtDisplay.Text);
            znak = button.Text;
            txtDisplay.Text = "";
        }

        private void Equals_Click(object sender, EventArgs e) 
        {
            try 
            {
                double digit2 = Convert.ToDouble(txtDisplay.Text);
                double result = 0;

                if (znak == "+")result = digit1 + digit2;
                if (znak == "-") result = digit1 - digit2;
                if (znak == "*") result = digit1 * digit2;
                if (znak == "/") result = digit1 / digit2;
            }
            catch 
            {
                MessageBox.Show("Ошибка!!!");
                txtDisplay.Text = "";
            }
        }
        private void C_Click(object sender, EventArgs e) 
        {
            txtDisplay.Text = "";
            digit1 = 0;
            znak = "";
        }
    }
}
