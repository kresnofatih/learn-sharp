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
            int x = 5; // declaration initialization, the 5 is a literal
            char characterC = 'c';
            string stringHello = "Hello";
            float floatNumber = 5.5f;
            double doubleNumber = 8.5;
            decimal decimalNumber = 4.5m;
            bool status = true;
            int y; // declaration
            y = 8; // initialization

            Console.WriteLine(x + y + floatNumber + doubleNumber + (double)decimalNumber); // casting
            Console.WriteLine(characterC);
            Console.WriteLine(status);
            Console.WriteLine(stringHello);
        }
    }
}
