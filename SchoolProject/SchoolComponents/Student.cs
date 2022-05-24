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
        private int _age;
        public Student(string name, int age, Dictionary<string, int> marks)
        {
            Name = name;
            Age = age;
            Marks = marks;
        }

        public int Id { get; private set; } = new Random().Next();

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 7)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Student age is less than 7");
                }
            }
        }


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
    }
}
