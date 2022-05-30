using NUnit.Framework;
using SchoolProject.SchoolComponents;
using SchoolProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTestProject
{
    public class BaseTest
    {
        protected const string StudentsJsonFile = "Students.json";
        protected const string Students2JsonFile = "Students2.json";

        protected School School { get; set; }

        [OneTimeSetUp]
        protected void InitializeSchool()
        {
            School school = new School("Sofia English High School", "Sofia, 1000, str. 1");

            List<Student> students = JsonDataFileReader.GetJArray(StudentsJsonFile).ToObject<List<Student>>();
            school.AddStudents(students);

            School = school;
        }
    }
}
