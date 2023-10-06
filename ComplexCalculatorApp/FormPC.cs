using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculatorApp
{
    public partial class FormPC : Form
    {
        public FormPC()
        {
            InitializeComponent();
        }

        private void FormPC_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AvoidLetters(e, textBox1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            AvoidLetters(e, textBox2);
        }
        void AvoidLetters(EventArgs e, TextBox tex)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tex.Text, "[^0-9]"))
            {
                tex.Text = tex.Text.Remove(tex.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                float pPrice = int.Parse(textBox1.Text);
                float cPrice = int.Parse(textBox2.Text);

                float difference=((cPrice - pPrice)/pPrice)*100;

                if (difference>0)
                {
                    Warning.Text = " ";

                    resultText.Text = "Price rose by " + Math.Round(difference, 3).ToString() + "%";
                }
                else if (difference < 0)
                {
                    Warning.Text = " ";
                    difference *= -1;
                    resultText.Text = "Price dropped down by " + Math.Round(difference, 3).ToString() + "%";
                }
                else
                {
                    resultText.Text = "No change happened in price";
                }

            }
            else if (textBox1.Text.Length == 0)
            {
                Warning.Text = "Please fill in the textbox with the initial price.";
            }
            else if (textBox2.Text.Length == 0)
            {
                Warning.Text = "Please fill in the textbox with the current price.";
            }
            else
            {
                Warning.Text = "Please fill in the textboxes with the values needed before pressing the button.";
            }
        }
    }
}
