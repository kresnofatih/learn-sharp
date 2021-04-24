using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public class Student : User, ITalk // inheriting an interface determines the methods compulsory to implement
    {
        public Student()
        {
            Console.WriteLine("Creating a student");// will be executed when constructor is stated
        }

        public Student(string firstName, string lastName) : base(firstName, lastName) // inherits properties of user
        // constructor overloaded with the one with parameters
        {

        }


        // will show error if the abstract method of its parent is not implemented in this class
        public override void SayHello()
        {
            Console.WriteLine("Hello, I'm a student. My name is " + FullName);
        }
    }
}
