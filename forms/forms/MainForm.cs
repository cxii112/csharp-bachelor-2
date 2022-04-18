using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {

                double a = double.Parse(this.textBox1.Text);
                double b = double.Parse(this.textBox2.Text);
                int c = int.Parse(this.textBox3.Text);
                resultLabel.Text = (a + b + c).ToString();
            }
            catch (FormatException)
            {
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rebootButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}