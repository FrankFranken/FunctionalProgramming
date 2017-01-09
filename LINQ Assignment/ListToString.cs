using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class FunctionalProgramming
    {
        //1. Write a function that takes in a list of strings and returns a copy of the list without duplicates.
        public void ProblemOne() 
        {
            List<string> numberstrings = new List<string> { "one", "one", "two", "three", "three", "four", "five", "five" };
            List<string> removestrings = (numberstrings.Distinct().ToList());
            foreach (var item in removestrings)
            {
                Console.WriteLine(item);
            }
        } 
        //2. Write a function that calculates the class grade average after dropping the lowest grade for each student.
        //That is: Write a function that takes in a list of strings of grades (e.g., one string might be "90,100,82,89,55"),
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        public void ProblemTwo()
        {
            string student1grades = "80, 85, 70, 73, 100, 90, 92, 52";
            var grades1 = (student1grades.Split(',').Select(int.Parse).ToList());
            grades1.Sort();
            var average1 = (from i in grades1 where i > grades1.Min() select i).Average();
            Console.WriteLine("STUDENT1 AVERAGE");
            Console.WriteLine(average1);

            string student2grades = "84, 68, 77, 71, 88, 50, 54, 72";
            var grades2 = (student2grades.Split(',').Select(int.Parse).ToList());
            grades2.Sort();
            var average2 = (from i in grades2 where i > grades2.Min() select i).Average();
            Console.WriteLine("STUDENT2 AVERAGE");
            Console.WriteLine(average2);

            List<double> classAverage = new List<double> {average1, average2};
            double average = classAverage.Average();
            Console.WriteLine("CLASS AVERAGE");
            Console.WriteLine(average);
        }
        //3. Write a function that takes in a string of letters(e.g., "Llewellyn") and returns a alphabetically ordered string 
        //corresponding to the letter frequency(e.g., "E2L4N1W1Y1")
        public void ProblemThree()
        {
            string letters = "Llewellyn";
            string upLetters = letters.ToUpper();
            char[] Alpha = upLetters.ToArray();
            Array.Sort(Alpha);
            var numberCount = from i in Alpha group i by i into joinletters select joinletters;
            foreach (var item in numberCount)
            Console.WriteLine($"{item.Key} {item.Count()}");
        }
    }
}
