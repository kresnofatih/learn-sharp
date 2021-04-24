using System; // imports all library
using System.Collections.Generic;

namespace CalebTuts // a namespace - used for organization
{
    class Program // a class - has members (such as a method)
    {
        static void Main(string[] args)
        // a method - contains a block of code, Main is the starting point
        // this is creating the method, you will need to invoke a method later.
        // For Main, it will not require us to invoke
        {
            Program myProgram = new Program(); //instantiate
            myProgram.PrintName();
        }

        public void PrintName()
        {
            User you = new User();
            you.FirstName = "Kresno";// will override the firstname default value to Irham
            you.LastName = "Fatih";
            Console.WriteLine(you.FullName); // kresno fatih

            User me = new User();
            me.FullName = "Kresno Fatih";
            Console.WriteLine(you.FullName); // kresno fatih

            User him = new User();
            him.FullName = "Fatih";
            Console.WriteLine(him.FullName); // fatih fatih

            Console.WriteLine("");

            List<User> users = new List<User>();
            users.Add(me);
            users.Add(you);
            users.Add(him);

            foreach(User user in users)
            {
                Console.WriteLine(user.FullName);
                //kresno fatih
                //kresno fatih
                //fatih fatih
            }

            takeUser(me);
            Console.WriteLine(me.FullName);//jamesfatih
        }

        public void takeUser(User user)
        {
            user.FirstName = "James";
        }
    }
}
