using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_CPC_ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked &&
                !radioButton2.Checked &&
                !radioButton3.Checked)
            {
                MessageBox.Show("Необходимо ответить!");
                return;
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Верно!");
                return;
            }

            MessageBox.Show("Неверно.");
        }

        private void submitButton2_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked &&
                !checkBox2.Checked &&
                !checkBox3.Checked &&
                !checkBox4.Checked)
            {
                MessageBox.Show("Необходимо ответить!");
                return;
            }

            if (checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Верно!");
                return;
            }

            MessageBox.Show("Неверно");
        }
    }
}
