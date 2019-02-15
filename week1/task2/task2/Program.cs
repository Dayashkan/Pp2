using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student // creating a class
    {
        public string Name; // name
        public string StudentId; // id 
        public int Year; // year of studing 

        // Constructor
        public Student(string name, string Id, int year)
        {
            Name = name;
            StudentId = Id;
            Year = year;
        }
        public Student(string stname, string id) // Constructor with two parameters
        {
            this.Name = stname; 
            this.StudentId = id;
        }
        // Method that calls name, id and year
        public void Print()
        {
            Console.WriteLine(Name + " " + StudentId + " " + Year);
        }
        // Method that increments the year and writes all new data 
        public void AddNumber(int year)
        {
            int nextYear = year + 1;
            Console.WriteLine(Name + " " + StudentId + " " + nextYear);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Call the constructor that has 3 parameters
            var person1 = new Student("Dayana", "18BD110552", 1);
            person1.Print(); // call method Print
            var person2 = new Student("Dayana", "18BD110552"); // call constructor that has 2 parameters
            person2.AddNumber(1); // call method AddNumber
            Console.ReadKey();

        }
    }
}
