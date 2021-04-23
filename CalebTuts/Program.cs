using System; // imports all library
using System.Collections.Generic;

namespace CalebTuts // a namespace - used for organization
{
    class Program // a class - has members (such as a method)
    {
        static void Main(string[] args)
        // a method - contains a block of code, Main is the starting point
        // this is creating the method, you will need to invoke a method later.
        // For Main, it will not require us to invoke
        {
            Program myProgram = new Program(); //instantiate
            myProgram.PrintName();
        }

        public void PrintName()
        {
            User me = new User();
            me.FirstName = "Kresno";
            me.LastName = "Fatih";

            me.Output(4);
            Console.Write(me.PrintFullName());
        }
    }
}
