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
        string _firstName = "FirstName";
        string _lastName = "LastName";

        // properties: gateway to our fields
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value.ToLower();
            }
        } // if get & set is not a set of code, autoamtically creates a field, if set, then it connects to a field
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value.ToLower();
            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                if(value.Split(" ").Length > 1)
                {
                    _firstName = value.Split(" ")[0].ToLower();
                    _lastName = value.Split(" ")[1].ToLower();
                } else
                {
                    _firstName = value.ToLower();
                    _lastName = value.ToLower();
                }
            }
        }

        public static void PrintUserFullName(User user)
        {
            Console.WriteLine(user.FullName);
        }

        public static void PrintListOfUserFullName(List<User> users)
        {
            foreach(User user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }
    }
}
