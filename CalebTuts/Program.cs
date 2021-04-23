﻿using System; // imports all library

namespace CalebTuts // a namespace - used for organization
{
    class Program // a class - has members (such as a method)
    {
        static void Main(string[] args)
            // a method - contains a block of code, Main is the starting point
            // this is creating the method, you will need to invoke a method later.
            // For Main, it will not require us to invoke
        {
            Person person = new Person();
            person.FirstName = "Kresno";
            person.LastName = "Fatih";

            string fullNameGuess = Console.ReadLine();

            if (fullNameGuess == person.GetFullName())
            {
                Console.WriteLine("Awesome");
            } else if(fullNameGuess == "Irham Isa" || fullNameGuess == "Zaki Fadhil")
            {
                Console.WriteLine("Awesome Too");
            } else
            {
                Console.WriteLine("You Suck");
            }
        }
    }
}
