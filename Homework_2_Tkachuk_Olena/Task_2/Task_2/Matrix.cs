using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Matrix
    {
        private int rows;
        private int columns;
        public int[,] colorsArray;

        public int Rows { get; set; }
        public int Columns { get; set; }

        public int[,] ColorsArray { get; set; }

        public Matrix()
        {
            Rows = rows;
            Columns = columns;
            ColorsArray = new int[rows, columns];
        }

        public Matrix(int rows, int columns)
        {
            if (rows < 0 || columns < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows));
            }

            Rows = rows;
            Columns = columns;
            ColorsArray = new int[rows, columns];

            Random random = new Random();
            
            for (int i = 0; i < ColorsArray.GetLength(0); i++)
            {
                for (int j = 0; j < ColorsArray.GetLength(1); j++)
                {
                    ColorsArray[i, j] = random.Next(0, 16);
                }
            }
           
            for (int i = 0; i < ColorsArray.GetLength(0); i++)
            {
                for (int j = 0; j < ColorsArray.GetLength(1); j++)
                {
                    Console.Write(ColorsArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void ColorInfo()
        {
            int color = 0;
            int firstIndex = 0;
            int lastIndex = 0;           
            int maxLength = 1;
            int array = ColorsArray[0, 0];

            for(int i = 0; i < ColorsArray.GetLength(0); i++)
            {
                for(int j = 0; j < ColorsArray.GetLength(1) - 1; j++)
                {
                    if (ColorsArray[i, j] == ColorsArray[i, j + 1])
                    {
                        color = ColorsArray[i, j];
                        maxLength++;
                        firstIndex = j;
                        lastIndex = j + maxLength - 1;
                        Console.WriteLine("Color of pixel: {0}\nFirst index: \t{1}\nLast index: \t{2}\nLength: \t{3}\n", color, firstIndex, lastIndex, maxLength);
                    }
                    
                }                
            }           


        }
       
    }
}

