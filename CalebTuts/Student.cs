using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public class Student : User
    {
        public Student()
        {
            Console.WriteLine("Creating a student");// will be executed when constructor is stated
        }
        
        
        // will show error if the abstract method of its parent is not implemented in this class
        public override void SayHello()
        {
            Console.WriteLine("Hello, I'm a student. My name is " + FullName);
        }
    }
}
