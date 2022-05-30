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
    [TestFixture]
    public class StudentAgeTests
    {
        private const string StudentJohnJsonFile = "StudentJohn.json";
        private const string StudentAnnaJsonFile = "StudentAnna.json";

        [Test]
        [Description("Validate Student age throws an exception when it's invalid.")]
        public void InvalidStudentAge()
        {
            Assert.Throws<ArgumentException>(InitializeStudentJohn);
        }
        private void InitializeStudentJohn()
        {
            School school = new School("Sofia English High School", "Sofia, 1000, str. 1");

            List<Student> students = JsonDataFileReader.GetJArray(StudentJohnJsonFile).ToObject<List<Student>>();
            school.AddStudents(students);
        }

        [Test]
        [Description("Validate Student age doesn't throw an exception when it's valid.")]
        public void ValidStudentAge()
        {
            Assert.DoesNotThrow(InitializeStudentAnna);
        }

        private void InitializeStudentAnna()
        {
            School school = new School("Sofia English High School", "Sofia, 1000, str. 1");

            List<Student> students = JsonDataFileReader.GetJArray(StudentAnnaJsonFile).ToObject<List<Student>>();
            school.AddStudents(students);
        }
    }
}
