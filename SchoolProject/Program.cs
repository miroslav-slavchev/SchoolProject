using Newtonsoft.Json.Linq;
using SchoolProject.Utils;
using SchoolProject.SchoolComponents;
using System.Collections.Generic;

namespace SchoolProject
{
    internal class Program
    {
        private const string StudentsJsonFile = "Students.json";

        static void Main(string[] args)
        {
            School school = new School("Sofia School", "Sofia, 1000, Center");

            JArray studentsArray = JsonDataFileReader.GetJArray(StudentsJsonFile);
            List<Student> students = studentsArray.ToObject<List<Student>>();
            school.AddStudents(students);

            school.GetExcelentStudents().ForEach(student => student.Speak());
        }
    }
}
