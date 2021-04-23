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
            for(int a = 0; a<5; a++)
            {
                for(int b = 0; b<=5; b++)
                {
                    if (b != a)
                    {
                        Console.Write("o");
                    } else
                    {
                        Console.WriteLine("o");
                        break;
                    }
                }
            }
        }
    }
}
