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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pCosts=new FormP();
            pCosts.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pPrice = new FormPC();
            pPrice.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pChance = new FormPB();
            pChance.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
