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
            Int32 x = 5; // .Net framework variables
            int y = (int) 3.99;// rounds down to 3
            Console.WriteLine(x);//5
            Console.WriteLine(y);//3

            float z = 5.5f; // float literals is different
            double p = 5.5; // bigger information
            decimal q = 39.4M; // double literals
            double r = double.NaN;

            Console.WriteLine(double.IsNaN(p));
            Console.WriteLine(double.IsNaN(r));
        }
    }
}
