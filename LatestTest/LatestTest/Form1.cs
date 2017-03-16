using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix;

namespace LatestTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.Width = 30; //ширина колонки                 
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.Width = 30;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column1.Width = 30;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column2.Width = 30;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridViewA.Columns.Add(column1);
            dataGridViewA.Columns.Add(column2);

            dataGridViewB.Columns.Add(column3);
            dataGridViewB.Columns.Add(column4);


            for (int i = 0; i < 2; ++i)
            {
                dataGridViewA.Rows.Add();
                dataGridViewB.Rows.Add();
            }
            //цикл по всем ячейкам
            //for (int i = 0; i < dataGridViewA.Rows.Count; ++i)
            //{
            //    for (int j = 0; j < dataGridViewA.Columns.Count; ++j)
            //    {
            //        //Значения ячеек хряняться в типе object
            //        //это позволяет хранить любые данные в таблице
            //        object o = dataGridViewA[j, i].Value;
            //    }
            //}
        }

        private void buttonIncreaseA_Click(object sender, EventArgs e)
        {
            int i = dataGridViewA.Columns.Count + 1;
            dataGridViewA.Columns.Add("column" + i, " ");
            dataGridViewA.Rows.Add();
        }

        private void buttonDecreaseA_Click(object sender, EventArgs e)
        {
            int i = dataGridViewA.Columns.Count;
            dataGridViewA.Columns.Remove("column" + i);
            dataGridViewA.Rows.RemoveAt(dataGridViewA.SelectedCells[0].RowIndex);
        }

        private void buttonIncreaseB_Click(object sender, EventArgs e)
        {
            int i = dataGridViewB.Columns.Count + 1;
            dataGridViewB.Columns.Add("column" + i, " ");
            dataGridViewB.Rows.Add();
        }

        private void buttonDecreaseB_Click(object sender, EventArgs e)
        {
            int i = dataGridViewB.Columns.Count;
            dataGridViewB.Columns.Remove("column" + i);
            dataGridViewB.Rows.RemoveAt(dataGridViewB.SelectedCells[0].RowIndex);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            dataGridViewC.Columns.Clear();
            dataGridViewC.Rows.Clear();

            if (radioDouble.Checked)
            {
                dataGridViewC = Calculator.MatrixAddition(dataGridViewC, 
                    MatrixGeneric<double>.FromArray(Calculator.DoubleConverter(dataGridViewA), new DoubleCalculator()), 
                    MatrixGeneric<double>.FromArray(Calculator.DoubleConverter(dataGridViewB), new DoubleCalculator()));
            }

            if (radioString.Checked)
            {
                dataGridViewC = Calculator.MatrixAddition(dataGridViewC,
                    MatrixGeneric<string>.FromArray(Calculator.StringConverter(dataGridViewA), new StringCalculator()),
                    MatrixGeneric<string>.FromArray(Calculator.StringConverter(dataGridViewB), new StringCalculator()));
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            dataGridViewC.Columns.Clear();
            dataGridViewC.Rows.Clear();

            if (radioDouble.Checked)
            {
                dataGridViewC = Calculator.MatrixSubtraction(dataGridViewC,
                    MatrixGeneric<double>.FromArray(Calculator.DoubleConverter(dataGridViewA), new DoubleCalculator()),
                    MatrixGeneric<double>.FromArray(Calculator.DoubleConverter(dataGridViewB), new DoubleCalculator()));
            }

            if (radioString.Checked)
            {
                dataGridViewC = Calculator.MatrixSubtraction(dataGridViewC,
                    MatrixGeneric<string>.FromArray(Calculator.StringConverter(dataGridViewA), new StringCalculator()),
                    MatrixGeneric<string>.FromArray(Calculator.StringConverter(dataGridViewB), new StringCalculator()));
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            dataGridViewC.Columns.Clear();
            dataGridViewC.Rows.Clear();

            if (radioDouble.Checked)
            {
                dataGridViewC = Calculator.MatrixMultiplication(dataGridViewC,
                    MatrixGeneric<double>.FromArray(Calculator.DoubleConverter(dataGridViewA), new DoubleCalculator()),
                    MatrixGeneric<double>.FromArray(Calculator.DoubleConverter(dataGridViewB), new DoubleCalculator()));
            }

            if (radioString.Checked)
            {
                dataGridViewC = Calculator.MatrixMultiplication(dataGridViewC,
                    MatrixGeneric<string>.FromArray(Calculator.StringConverter(dataGridViewA), new StringCalculator()),
                    MatrixGeneric<string>.FromArray(Calculator.StringConverter(dataGridViewB), new StringCalculator()));
            }
        }
    }
}
