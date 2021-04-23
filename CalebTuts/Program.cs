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
            List<List<int>> nestedLists = new List<List<int>>()
            {
                new List<int>{5, 6, 7},
                new List<int>{34, 20, 39, 28}
            };
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

            foreach(List<int> nestedList in nestedLists)
            {
                foreach(int num in nestedList)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
