using System;

namespace Nested_For_and_2D_Arrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Printing the array using a foreach loop");
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPrinting the array using a nested for loop");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

            }

            Console.WriteLine("\nPrinting the even numbers in the array using a nested for loop, and the diagonals L - R");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    /*if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }*/

                    if(i == j)
                    {
                        Console.WriteLine(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("");
            }

            Console.WriteLine("\nPrinting the diagonals L - R using a single for loop");
            for(int i = 0; i < matrix.GetLength(0); i++)
            { //this loops through and prints the elements in the diagonals
                Console.WriteLine(matrix[i, i] + " ");
            }

            Console.WriteLine("\nPrinting the diagonals R - L using a for loop");
            for (int i = 0,j = 2; i < matrix.GetLength(0); i++, j--)
            { //this loops through and prints the elements in the diagonals from left to right
                Console.WriteLine(matrix[i, j] + " ");
            }
        }
    }
}
