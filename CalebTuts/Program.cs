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
            // lists
            List<int> grades = new List<int>() { 5, 19 };
            grades.Add(20);
            grades.Insert(2, 15);

            Console.WriteLine(grades[0]); //5
            Console.WriteLine(grades[1]);//19
            Console.WriteLine(grades[2]);//15
            Console.WriteLine(grades[3]);//20

            //grades.Clear();

            // for loop for lists
            for(int i = 0; i<grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }

            // for each for lists
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
