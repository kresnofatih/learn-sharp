using System; // imports all library

namespace CalebTuts // a namespace - used for organization
{
    class Program // a class - has members (such as a method)
    {
        static void Main(string[] args)
            // a method - contains a block of code, Main is the starting point
            // this is creating the method, you will need to invoke a method later.
            // For Main, it will not require us to invoke
        {
            // arrays
            int[,] grades = new int[5, 3];
            grades[0, 2] = 8;
            //Console.WriteLine(grades[0, 2]);

            int[,] numbers = {// 2d array
                { 1, 2 }, 
                { 2, 3 }, 
                { 4, 2 }
            };
            Console.WriteLine(numbers[0, 1]);
            Console.WriteLine(numbers.GetLength(0));//row=3
            Console.WriteLine(numbers.GetLength(1));//col=2

            int[][] newNumbers = // jagged arrays
            {
                new int[]{3, 4,5},
                new int[]{2,3,1,7}
            };

            Console.WriteLine(newNumbers.Length);//2
            Console.WriteLine(newNumbers[0].Length);// 3
            Console.WriteLine(newNumbers[1].Length);// 4

        }
    }
}
