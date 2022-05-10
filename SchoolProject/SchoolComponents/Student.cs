using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.SchoolComponents
{
    /// <summary>
    /// Represents a Student object (encapsulates Student Data).
    /// </summary>
    public class Student
    {
        public Student(int id, string name, int age, Dictionary<string,int> marks)
        {
            Id = id;
            Name = name;
            InitializeAge(age);
            Marks = marks;
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsExcelent => Marks.Values.Where(value => value == 6).Count() == Marks.Values.Count;

        public Dictionary<string, int> Marks { get; set; }

        public void Speak() => Console.WriteLine(Message);

        private int YearsLeft => 18 - Age;

        private string Message
        {
            get
            {
                string message;
                if (Age < 18)
                {
                    message = $"Hello I'm {Name} and I've got {YearsLeft} years to graduate.";
                }
                else
                {
                    message = $"Hello I’m {Name} and I'll graduate this year.";
                }
                return message;
            }
        }

        private void InitializeAge(int age)
        {
            if (age >= 7)
            {
                Age = age;
            }
            else
            {
                throw new ArgumentException("Student age is less than 7");
            }
        }
    }
}
