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
        string _firstName = "FATIH";

        // properties: gateway to our fields
        public string FirstName
        {
            get
            {
                return _firstName.ToLower();
            }
        } // if get & set is not a set of code, autoamtically creates a field, if set, then it connects to a field
        public string LastName { get; set; }

        public string ReturnFullName()
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
