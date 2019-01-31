using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Matrix matTest = new Matrix(3, 3);
            matTest.displayInfo();
            matTest.initializeRows();
            matTest.displayMatrix();
            Console.ReadKey();

        }
    }

    public class Matrix
    {
        int rows;
        int columns;

        int[,] matrix;

        // CONSTRUCTOR
        public Matrix (int _rows, int _columns)
        {
            rows = _rows;
            columns = _columns;

            matrix = new int[_rows, _columns];


        }

        public void displayInfo()
        {
            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("Columns: " + columns);

        }

        public void initializeRows()
        {

            for (int i = 0; i < rows; i++)
            {
                int _i = i + 1;
                Console.WriteLine("Row: " + _i + " With " + columns + " columns");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void displayMatrix()
        {
            // Cycles through the rows one at a time entering all of the columns data at once then moving onto the next row.
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("_________"); // change this to hve a for loop that reads in how many digits the matrix is to fit it to exact size
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("End Function");
        }
    }
}


