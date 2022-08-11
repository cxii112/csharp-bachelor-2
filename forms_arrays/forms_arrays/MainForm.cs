using System;
using System.Windows.Forms;

namespace forms_arrays
{
    public partial class MainForm : Form
    {
        private int[,] _matrix;
        private int N;
        private int M;
        public MainForm()
        {
            InitializeComponent();
            N = 5;
            M = 5;
        }

        private int[,] InitMatrix(int n, int m)
        {
            Random random = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }

            return matrix;
        }

        private void UpdateMatrix()
        {
            _matrix = InitMatrix(N, M);
            dataGridView1.RowCount = M;
            dataGridView1.ColumnCount = N;
            // dataGridView1.DataSource = MatrixToRow();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = _matrix[i, j].ToString();
                    dataGridView1.UpdateCellValue(i, j);
                }
            }
        }

        private int SummMatrixElements()
        {
            int sum = 0;

            foreach (int number in _matrix)
            {
                sum += number;
            }

            return sum;
        }

        private void updateMatrixButton_Click(object sender, EventArgs e)
        {
            UpdateMatrix();
            sumLabel.Text = $"{SummMatrixElements()}";
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
