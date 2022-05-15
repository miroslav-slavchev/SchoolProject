using Homework8.SchoolComponents;
using Homework8.Utils;
using System;
using System.Collections.Generic;

namespace Homework8
{
    internal class Program
    {
        private const string StudentsTextFile = "Students.txt";

        static void Main(string[] args)
        {
            School school = new School("Sofia School", "Sofia, 1000, Center");

            string[] textLines = TextFilereader.GetFileTextContentLines(StudentsTextFile);
            List<Student> students = new();

            for (int i = 0; i < textLines.Length; i++)
            {
                Student person = GetPersonDataFromLine(i, textLines[i]);
                school.AddStudent(person);
            }

            school.GetExcelentStudents().ForEach(student => student.Speak());
        }

        private static Student GetPersonDataFromLine(int id, string textData)
        {
            string[] data = textData.Split(":");
            string[] baseData = data[0].Split(",");
            string marksData = data[1];

            string name = baseData[0];
            int age = int.Parse(baseData[1]);
            Dictionary<string, int> marks = GetMarksDictionary(marksData);

            return new Student(id, name, age, marks);
        }

        private static Dictionary<string, int> GetMarksDictionary(string marksData)
        {
            Dictionary<string, int> marks = new Dictionary<string, int>();
     
            string[] subjectPairs = marksData.Split(",");
            foreach (var subjectPair in subjectPairs)
            {
                string[] subjectData = subjectPair.Split("-");
                marks.Add(subjectData[0], int.Parse(subjectData[1]));
            }

            return marks;
        }
    }
}
