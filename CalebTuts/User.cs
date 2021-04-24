using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public abstract class User
    {
        public User()
        {
            Console.WriteLine("Creating a User"); // will be executed by all derivate class constructor functions
        }
        // abstract keyword is for preventing other developers from creating a User class directly
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string FirstName { get; set; } = "FirstName";
        public string LastName { get; set; } = "LastName";
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
