using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public abstract class User
    {
        // abstract keyword is for preventing other developers from creating a User class directly
        public User()
        {
            Console.WriteLine("Creating a User"); // will be executed by all derivate class constructor functions
        }

        public User(string firstName, string lastName) // constructor overloaded with the one with parameters
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string FirstName { get; } = "FirstName"; // read only
        public string LastName { get; } = "LastName";
        public bool Verified { get; set; } = false; // by default the property value is false
        /*
        public virtual void SayHello()
        {
            Console.WriteLine("Hello, I'm "+FirstName);
        }
        */

        public abstract void SayHello();
        // abstract keyword makes overriding this method compulsory in the derivative method
    }
}
