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
            int a = 0;
            while (a < 10)
            {
                a += 1;
                Console.WriteLine(a);
            }

            int b = 0;
            do
            {
                b += 1;
                Console.WriteLine(b);
            } while (b < 10);

            for(int c = 0; c<10; c++)
            {
                Console.WriteLine(c+1);
            }
        }
    }
}
