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
            // Assert.IsTrue(School.Students.Count == 4);
            // Assert.That(School.Students.Count == 4, Is.True);
            // Assert.AreEqual(4, School.Students.Count);
            Assert.That(School.Students, Has.Count.EqualTo(4));
        }

        [Test]
        [Description("Check that the student lists match.")]
        public void CheckStudentLists()
        {
            List<string> students1 = JsonDataFileReader.GetJArray(StudentsJsonFile).ToObject<List<Student>>().Select(student => student.Name).ToList();
            List<string> students2 = JsonDataFileReader.GetJArray(StudentsJsonFile).ToObject<List<Student>>().Select(student => student.Name).ToList();
            CollectionAssert.AreEqual(students1, students2);
        }

        [Test]
        [Description("Check that the list contains an item.")]
        public void CheckStudentLists2()
        {
            List<string> students = JsonDataFileReader.GetJArray(StudentsJsonFile).ToObject<List<Student>>().Select(student => student.Name).ToList();
            CollectionAssert.Contains(students, "John");
            CollectionAssert.DoesNotContain(students, "Kate");
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
    }
}
