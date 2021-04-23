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

        public string PrintFullName()
        {
            string message = "";
            message += FirstName;
            message += " ";
            message += LastName;

            return message;
        }

        public void Output(int timesToOutput)
        {
            for(int i=0; i<timesToOutput; i++)
            {
                Console.WriteLine(FirstName);
                Console.WriteLine(LastName);
            }
        }
    }
}
