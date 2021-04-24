using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebTuts
{
    public class User
    {
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
    }
}
