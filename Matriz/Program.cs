using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number of row and column of matrix: ");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int cont = 0;

            double[,] mat = new double[row, col];

            for(int i = 0; i < row; i++)
            {
                Console.Write("Type matrix number: ");
                string[] numbers = Console.ReadLine().Split(" ");
                for(int j = 0; j < col; j++)
                {
                    mat[i, j] = int.Parse(numbers[j]);
                }
            }
            Console.WriteLine("Main diagonal!");
            for(int i = 0; i < row; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            Console.WriteLine("Total of negative numbers!");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if(mat[i,j] < 0)
                        cont++;
                }
            }
            Console.Write(cont);

        }
    }
}
