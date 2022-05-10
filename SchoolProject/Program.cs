using Newtonsoft.Json.Linq;
using SchoolProject.Utils;
using SchoolProject.SchoolComponents;

namespace SchoolProject
{
    internal class Program
    {
        private const string StudentsJsonFile = "Students.json";

        static void Main(string[] args)
        {
            School school = new School("Sofia School", "Sofia, 1000, Center");
            JArray studentsArray = JsonDataFileReader.GetJArray(StudentsJsonFile);
            for (int i = 0; i < studentsArray.Count; i++)
            {
                Student student = studentsArray[i].ToObject<Student>();
                school.AddStudent(student);
            }

            var excelentStudents = school.GetExcelentStudents();
            foreach (Student student in excelentStudents)
            {
                student.Speak();
            }
        }
    }
}
