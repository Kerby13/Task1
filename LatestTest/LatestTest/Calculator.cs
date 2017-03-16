using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix;

namespace LatestTest
{
    class Calculator
    {
        public static double[,] DoubleConverter(DataGridView datagrid)
        {
            double[,] array = new double[datagrid.RowCount, datagrid.ColumnCount];
            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int j = 0; j < datagrid.ColumnCount; j++)
                {
                    array[i, j] = Convert.ToDouble(datagrid[i, j]);
                }
            }
            return array;
        }

        public static string[,] StringConverter(DataGridView datagrid)
        {
            string[,] array = new string[datagrid.RowCount, datagrid.ColumnCount];
            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int j = 0; j < datagrid.ColumnCount; j++)
                {
                    array[i, j] = Convert.ToString(datagrid[i, j]);
                }
            }
            return array;
        }

        //public static Complex[,] ComplexConverter(DataGridView datagrid)
        //{
        //    Complex[,] array = new Complex[datagrid.RowCount, datagrid.ColumnCount];
        //    for (int i = 0; i < datagrid.RowCount; i++)
        //    {
        //        for (int j = 0; j < datagrid.ColumnCount; j++)
        //        {
        //            Convert.ToString(datagrid[i, j]);

        //        }
        //    }
        //    return array;
        //}

        public static DataGridView MatrixAddition(DataGridView table3, MatrixGeneric<double> m1, MatrixGeneric<double> m2)
        {
            MatrixGeneric<double> result = m1 + m2;
            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    table3[i, j].Value = result[i, j];
                }
            }
            return table3;
        }

        public static DataGridView MatrixAddition(DataGridView table3, MatrixGeneric<string> m1, MatrixGeneric<string> m2)
        {
            MatrixGeneric<string> result = m1 + m2;
            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    table3[i, j].Value = result[i, j];
                }
            }
            return table3;
        }

        public static DataGridView MatrixSubtraction(DataGridView table3, MatrixGeneric<double> m1, MatrixGeneric<double> m2)
        {
            MatrixGeneric<double> result = m1 - m2;
            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    table3[i, j].Value = result[i, j];
                }
            }
            return table3;
        }

        public static DataGridView MatrixSubtraction(DataGridView table3, MatrixGeneric<string> m1, MatrixGeneric<string> m2)
        {
            MatrixGeneric<string> result = m1 - m2;
            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    table3[i, j].Value = result[i, j];
                }
            }
            return table3;
        }

        public static DataGridView MatrixMultiplication(DataGridView table3, MatrixGeneric<double> m1, MatrixGeneric<double> m2)
        {
            MatrixGeneric<double> result = m1 * m2;
            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    table3[i, j].Value = result[i, j];
                }
            }
            return table3;
        }       

        public static DataGridView MatrixMultiplication(DataGridView table3, MatrixGeneric<string> m1, MatrixGeneric<string> m2)
        {
            MatrixGeneric<string> result = m1 * m2;
            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    table3[i, j].Value = result[i, j];
                }
            }
            return table3;
        }       
    }
}
