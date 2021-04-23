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
            int a = 39;
            bool isCorrect = a > 3 ? true : false;
            Console.WriteLine(isCorrect);

            if (a > 3) Console.WriteLine("a>3");
        }
    }
}
