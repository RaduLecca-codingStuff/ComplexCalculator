using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculatorApp
{
    public partial class FormPB : Form
    {
        public FormPB()
        {
            InitializeComponent();
        }

        private void FormPB_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0 && textBox2.Text.Length!=0) 
            {
                float pOutcomes = int.Parse(textBox1.Text);
                float tOutcomes = int.Parse(textBox2.Text);

                if(pOutcomes <= tOutcomes)
                {
                    Warning.Text = " ";
                    float percentage =  (pOutcomes / tOutcomes)*100;
                    resultText.Text = Math.Round(percentage,3).ToString() + "%";
                }
                else if(pOutcomes > tOutcomes)
                {
                    Warning.Text = "Number of desired outcomes out of an ammount of possible outcomes cannot be higher than the number of possible outcomes.";
                }
            
            }
            else if(textBox1.Text.Length == 0 && textBox2.Text.Length != 0)
            {
                Warning.Text = "Please fill in the textbox with the number of desired outcomes.";
            }
            else if(textBox2.Text.Length == 0 && textBox1.Text.Length != 0)
            {
                Warning.Text = "Please fill in the textbox with the number of possible outcomes.";
            }
            else
            {
                Warning.Text = "Please fill in the textboxes with the values needed before pressing the button.";
            }
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
    }
}
