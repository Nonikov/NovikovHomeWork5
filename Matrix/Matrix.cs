using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        int[,] matrix;
        Random random;

        public Matrix(int x, int y)
        {
            matrix = new int[x, y];
            random = new Random();
            Initializer();
        }

        void Initializer()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 99);
                }
            }
        }

        public void Addition(int[,] array)
        {
            int[,] resMassiv = new int[matrix.Length, array.Length];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    resMassiv[i, j] = matrix[i, j] + array[i, j];
            array = resMassiv;
        }

        public void Multiply(int[,] array)
        {
            if (matrix.GetLength(1) != array.GetLength(0))
                throw new ArgumentException("Invalid arrays length");
            int commonLength = matrix.GetLength(1);

            int[,] res = new int[matrix.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    int nextVal = 0;
                    for (int k = 0; k < commonLength; k++)
                    {
                        nextVal += matrix[i, k] * array[k, j];
                    }
                    res[i, j] = nextVal;
                    Console.Write("{0} ", res[i, j]);
                }
                Console.WriteLine();
            }
            matrix = res;
        }

        public void Show()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]:d2} ");
                }
                Console.WriteLine();
            }
        }


    }
}
