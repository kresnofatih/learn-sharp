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
            int number = 38;
            Console.WriteLine(number);//38
            AddFiveByReference(ref number);
            Console.WriteLine(number);//38
        }

        static void AddFiveByReference(ref int number)// creates a new value (pass by value)
        {
            //Console.WriteLine(number);//38
            number += 5;
            //Console.WriteLine(number);//43
        }
    }
}
