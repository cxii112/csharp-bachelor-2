using System;
using System.Collections.Generic;
using System.Windows.Forms;
using forms_CPC.Controllers;
using forms_CPC.Models;

namespace forms_CPC
{
    public partial class MainForm : Form, ITableView
    {
        private readonly TableLayoutController _tableLayoutController;

        public MainForm()
        {
            InitializeComponent();
            _tableLayoutController = new TableLayoutController(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _tableLayoutController.AddFunctionData();
        }

        public void AddFunctionData(List<FunctionData> source)
        {
            int row = tableLayoutPanel1.RowCount;
            source.ForEach(item =>
            {
                Label labelX = new Label();
                labelX.Text = item.X.ToString();
                tableLayoutPanel1.Controls.Add(labelX, 0, row);

                Label labelY = new Label();
                labelY.Text = item.Y.ToString();
                tableLayoutPanel1.Controls.Add(labelY, 1, row);

                row++;
            });
        }
    }
}