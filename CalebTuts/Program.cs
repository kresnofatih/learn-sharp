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
            Console.WriteLine("Hello World!2"); // this is a statement, this is a static method of class Console
            Program myProgram = new Program(); // creating an instance of myProgram
            myProgram.Print();  // invoking a new method
        }

        void Print()
        {
            Console.WriteLine("Fatih"); // this is a statement
            Console.WriteLine("Irham Zaki Fatih sukses dunia akhirat amin yra"); // this is a statement
        }
    }
}
