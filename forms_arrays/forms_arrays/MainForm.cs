using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private int[] MatrixToRow()
        {
            int[] row = new int[N * M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    row[i * N + j] = _matrix[i, j];
                }
            }

            return row;
        }

        private void updateMatrixButton_Click(object sender, EventArgs e)
        {
            UpdateMatrix();
        }
    }
}
