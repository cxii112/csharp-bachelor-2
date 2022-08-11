using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_arrays_CPC
{
    public partial class MainForm : Form
    {
        private List<int> _numbers;
        private const int Count = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private List<int> GenerateNumbers(int count)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(-10, 10) - (i / 2));
            }

            return numbers;
        }

        private void nextFormButton_Click(object sender, EventArgs e)
        {
            _numbers = GenerateNumbers(Count);
            Form2 form2 = new Form2(this, _numbers);
            form2.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            this.Dispose();
            this.Close();
        }
    }
}