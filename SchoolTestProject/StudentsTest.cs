using Newtonsoft.Json.Linq;
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
    public class StudentsTest : BaseTest
    {
        [Test]
        [Description("Validate the all students count.")]
        public void StudentsCount()
        {
            Assert.That(School.Students, Has.Count.EqualTo(4));
        }

        [Test]
        [Description("Check that the student lists match.")]
        public void CheckStudentLists()
        {
            List<Student> students1 = JsonDataFileReader.GetJArray(StudentsJsonFile).ToObject<List<Student>>();
            List<Student> students2 = JsonDataFileReader.GetJArray(Students2JsonFile).ToObject<List<Student>>();
            CollectionAssert.AreEqual(students1, students2);
        }

        [Test]
        [Description("Validate the all students count.")]
        public void StudentsCountCompareToJArray()
        {
            JArray jarray = JsonDataFileReader.GetJArray(StudentsJsonFile);
            Assert.AreEqual(School.Students.Count, jarray.Count);
        }

        [Test]
        [Description("Validate first student jObject is properly parsed.")]
        public void ValidateFirstObjectDataIsProperlyParsed()
        {
            JObject jObject = JsonDataFileReader.GetJArray(StudentsJsonFile).First.ToObject<JObject>();
            Student student = School.Students.First();

            string name = jObject["Name"].ToObject<string>();
            int age = jObject["Age"].ToObject<int>();
            Dictionary<string, int> marks = jObject["Marks"].ToObject<Dictionary<string, int>>();

            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(age, student.Age);
            foreach (var pair in marks)
            {
                Assert.AreEqual(student.Marks[pair.Key], pair.Value);
            }
        }

        [Test]
        [Description("Validate the еxcellent students count.")]
        public void ExcellentStudentsCount()
        {
            Assert.That(School.GetExcelentStudents(), Has.Count.EqualTo(2));
        }

        [Test]
        [Description("Validate students marks range is [2..6].")]
        public void ValidateMarksRange()
        {
            foreach (Student student in School.Students)
            {
                foreach (var value in student.Marks.Values)
                {
                    Assert.That(value, Is.GreaterThanOrEqualTo(2).And.LessThanOrEqualTo(6));
                }
            }
        }

        [Test]
        [TestCase(5, 10, 15)]
        [TestCase(8, 2, 10)]
        public void Tests(int a, int b, int expectedSum)
        {
            int sum = a + b;
            Assert.AreEqual(expectedSum, sum);
        }
    }
}
