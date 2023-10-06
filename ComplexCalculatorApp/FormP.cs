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
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }

        private void FormP_Load(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            AvoidLetters(e, textBox3);
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
            if(textBox1.Text.Length!=0 && textBox3.Text.Length != 0 )
            {
                float fCosts = int.Parse(textBox1.Text);
                float vCosts;
                if (textBox2.Text.Length == 0)
                    vCosts = 0;
                else
                    vCosts = int.Parse(textBox2.Text);
                float nrOfUnits = int.Parse(textBox3.Text);
                float tCost = (fCosts + vCosts) / nrOfUnits;
                Total.Text = Math.Round(tCost,3).ToString();
            }
            else
            {
                Warning.Text="Please fill at least the fixed costs or the number of units.";
            }


        }
    }
}
