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
    public partial class Form2 : Form
    {
        private readonly List<int> _source;
        public Form2(List<int> source)
        {
            _source = source;
            InitializeComponent();
            DisplayArray();
            DisplayNegativesArray();
        }

        private void DisplayArray()
        {
            for (int i = 0; i < _source.Count; i++)
            {
                sourceListBox.Items.Insert(i, _source[i]);
            }
        }

        private void DisplayNegativesArray()
        {
            List<int> negatives = SortNegatives(_source);
            for (int i = 0; i < negatives.Count; i++)
            {
                negativesListBox.Items.Insert(i, negatives[i]);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<int> SortNegatives(List<int> source)
        {
            for (int i = 0; i < source.Count - 1; i++)
            {
                int min = source[i];
                int minIndex = i;
                for (int j = i + 1; j < source.Count; j++)
                {
                    if (source[j] < min)
                    {
                        min = source[j];
                        minIndex = j;
                    }
                }

                int temp = source[i];
                source[i] = source[minIndex];
                source[minIndex] = temp;
            }

            List<int> negatives = new List<int>();
            source.ForEach(number =>
            {
                if (number < 0)
                {
                    negatives.Add(number);
                }
            });
            return negatives;
        }
    }
}
