using System;

namespace MultiDimension_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix; //declare 2D array
            int[,,] threeD;  //declare 3D array

            // 2D array
            int[,] array2d = new int[,]
            {
                { 1,2,3 },  //row 0
                {4,5,6 },  //row 1
                {7,8,9 }  //row 2
            };

            Console.WriteLine($"Central value is {array2d[1, 1]}"); //row 1 value 1
            Console.WriteLine($"Last row first value is {array2d[2, 0]}");  //row 2 value 0

            string[,,] array3D = new string[,,]
            { //first dimension ... depth
                {  //second dimension ... heigth
                    { "000" , "001" }, //these are the third dimension  ...  length
                    { "010" , "011" },
                    {"First text entry", "And this is more text" }
                },
                {
                    { "100", "101" },
                    { "110", "111" },
                    {"Have to even out the arrays", "Last entry" }
                }
            };

            Console.WriteLine($"In the 3D Array, the 3rd set first number of 4 sets of 2 is {array3D[1, 1, 0]}");
            Console.WriteLine($"In the 3D Array, the 1st set first number of 4 sets of 2 is {array3D[0, 0, 0]}");
            Console.WriteLine($"In the 3D Array, the 4th set last number of 4 sets of 2 is {array3D[1, 1, 1]}");
            Console.WriteLine($"To access the Text in the array, the {array3D[0, 2, 0]} is here at [0,2,0]");
            Console.WriteLine($"To access the Text in the array, the {array3D[1, 2, 1]} is here at [1,2,1]");

            //can also declare array this way
            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            Console.WriteLine($"The value of [1,1] is {array2DString[1, 1]}");
            array2DString[1, 1] = "Chicken";
            Console.WriteLine($"The value of [1,1] is now {array2DString[1, 1]}");

            //get the dimension of an array when you don't know it
            int dimensions = array3D.Rank;
            Console.WriteLine($"The dimensions of array3d is {dimensions}");

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };  //valid array declaration
        }
    }
}
