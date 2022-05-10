using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.SchoolComponents
{
    /// <summary>
    /// School.
    /// </summary>
    public class School
    {
        public School(string name, string address)
        {
            Name = name;
            Address = address;
            Students = new List<Student>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public List<Student> Students { get; set; } 

        public List<Student> GetExcelentStudents() => Students.Where(student => student.IsExcelent).ToList();

        public void AddStudents(List<Student> students) => Students.AddRange(students);

        public void AddStudent(Student student) => Students.Add(student);

        public void RemoveStudent(int studentId) => Students.Remove(GetStudentById(studentId));

        private Student GetStudentById(int studentId) => Students.Where(student => student.Id == studentId).First();
    }
}
