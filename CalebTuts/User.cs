using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public class User
    {
        // fields: defined at the class level (not the recommended way to store information)
        //string firstName;

        // properties: gateway to our fields
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Output()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }
}
