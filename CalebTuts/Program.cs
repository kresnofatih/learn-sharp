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
            int[] grades = new int[10];
            for(int a = 0; a<10; a++)
            {
                grades[a] = a * 10;
            }

            int[] numbers = { 0, 1, 2, 3, 4 };
            Console.WriteLine(numbers.Length);
            for(int a=0; a <numbers.Length; a++)
            {
                Console.WriteLine(numbers[a]);
            }
            Console.WriteLine(Array.IndexOf(numbers, 3));
        }
    }
}
