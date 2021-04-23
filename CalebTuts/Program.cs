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
            int number = -5; //value type
            int newNumber = number; // value

            Console.WriteLine(number);//-5
            Console.WriteLine(newNumber);//-5

            number = 29;
            Console.WriteLine(number);//29
            Console.WriteLine(newNumber);//-5


            int[] firstArray = { -7 };
            int[] secondArray = firstArray;

            Console.WriteLine(firstArray[0]);//-7
            Console.WriteLine(secondArray[0]);//-7

            firstArray[0] = 24;

            Console.WriteLine(firstArray[0]);//24
            Console.WriteLine(secondArray[0]);//24
        }
    }
}
