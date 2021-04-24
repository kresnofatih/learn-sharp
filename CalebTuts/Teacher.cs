using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public class Teacher : User
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, I'm a teacher. My name is " + FullName);
        }
    }
}
