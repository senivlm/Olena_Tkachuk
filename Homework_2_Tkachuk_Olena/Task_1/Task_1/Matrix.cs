using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Matrix
    {
        private int rows;
        private int columns;     
//Ви дозволили зміну розміру, не змінивши виділену пам'ять
        public int Rows
        {
            get;
            set;
        }

        public int Columns
        {
            get;
            set;
        }

        public int[,] MatrixArray
        {
            get;
            set;
        }

        public Matrix()
        {
            Rows = rows;
            Columns = columns;
            MatrixArray = new int[rows, columns];
        }

            
        public Matrix(int rows, int columns)
        {
            if (rows < 0 || columns < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows));
            }            
                       
            Rows = rows;
            Columns = columns;
            MatrixArray = new int[rows, columns];
        }

        public Matrix(int[,] matrixArray)
        {
            MatrixArray = matrixArray;
        }


        public void ShowArray()
        {
            for (int i = 0; i < MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixArray.GetLength(1); j++)
                {
                    Console.Write(MatrixArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void VerticalSnakeFromLeft(int firstNumber)
        {//Друк і заповнення в одному методі!!!
            Console.WriteLine("Vertical snake from left to right");

            for (int i = 0; i < MatrixArray.GetLength(1); i++)
            {           
                if (i % 2 == 0)
                {
                   for (int j = 0; j < MatrixArray.GetLength(0); j++)
                   {
                        MatrixArray[j, i] = firstNumber++;
                   }
                }
                else
                {
                    for (int j = MatrixArray.GetLength(0) - 1; j >= 0; j--)
                    {
                        MatrixArray[j, i] = firstNumber++;
                    }
                }                      
     
            }
            ShowArray();
        }

        public void VerticalSnakeFromRight(int firstNumber)
        {
            Console.WriteLine("Vertical snake from right to left");

            for (int i = 0; i < MatrixArray.GetLength(1); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < MatrixArray.GetLength(0); j++)
                    {
                        MatrixArray[j, i] = firstNumber--;
                    }
                }
                else
                {
                    for (int j = MatrixArray.GetLength(0) - 1; j >= 0; j--)
                    {
                        MatrixArray[j, i] = firstNumber--;
                    }
                }
            }
            ShowArray();
        }

        public void DiagonalSnakeFromLeftSide(int firstNumber)
        {
            Console.WriteLine("Diagonal snake from left to right");
            if (Rows != Columns)
            {
                throw new ArithmeticException("Matrix must be square");
            }

            int x = 0, y = 0;
            MatrixArray[0, 0] = firstNumber;
            int step = -1;

            for (int i = 2; i <= Rows * Columns; i++)
            {
                int xNextStep = x - step;
                int yNextStep = y + step;
// Показати на парі, запустивши для парного і непарного розміру матриці.
                if (xNextStep < 0 || yNextStep < 0 || xNextStep == Rows || yNextStep == Columns)
                {
                    step *= -1;
                }

                y = xNextStep == Rows ? yNextStep + 2 : yNextStep < 0 ? 0 : yNextStep == Rows ? Rows - 1 : yNextStep;
                x = yNextStep == Columns ? xNextStep + 2 : xNextStep < 0 ? 0 : xNextStep == Columns ? Columns - 1 : xNextStep;

                MatrixArray[y, x] = i;
            }


            ShowArray();
        }

        public void DiagonalSnakeFromRightSide(int firstNumber)
        {
            Console.WriteLine("Diagonal snake from right to left");

            if (Rows != Columns)
            {
                throw new ArithmeticException("Matrix must be square");
            }

            int x = 0, y = 0;
            MatrixArray[0, 0] = firstNumber;
            int step = -1;

            for (int i = 2; i <= Rows * Columns; i++)
            {
                int xNextStep = x - step;
                int yNextStep = y + step;

                if (xNextStep < 0 || yNextStep < 0 || xNextStep == Rows || yNextStep == Columns)
                {
                    step *= -1;
                }

                y = xNextStep == Rows ? yNextStep + 2 : yNextStep < 0 ? 0 : yNextStep == Rows ? Rows - 1 : yNextStep;
                x = yNextStep == Columns ? xNextStep + 2 : xNextStep < 0 ? 0 : xNextStep == Columns ? Columns - 1 : xNextStep;

                MatrixArray[y, x] = firstNumber - i + 1;
            }

            ShowArray();
        }

        public void MatrixSnake()
        {
            Console.WriteLine("Snake array");

            int step = 1;
            int counter = 0;
            int x = 0, y = 0;

            while (counter < Rows * Columns)
            {
                y++;

                for (x = y - 1; x < Columns - y + 1; x++)
                {
                    MatrixArray[y - 1, x] = step++;
                    counter++;
                }

                for (x = y; x < Rows - y + 1; x++)
                {
                    MatrixArray[x, Columns - y] = step++;
                    counter++;
                }

                for (x = Columns - y - 1; x >= y - 1; x--)
                {
                    MatrixArray[Rows - y, x] = step++;
                    counter++;
                }

                for (x = Rows - y - 1; x >= y; x--)
                {
                    MatrixArray[x, y - 1] = step++;
                    counter++;
                }
            }
            ShowArray();
        }

        public override string ToString()
        {
            string result = "";

            for(int i = 0; i < MatrixArray.GetLength(0); i++)
            {
                for(int j = 0; j < MatrixArray.GetLength(1); j++)
                {
                   result += MatrixArray[i, j] + "\t";
                    Console.WriteLine();
                }
            }
            return result;
        }
    }
}
