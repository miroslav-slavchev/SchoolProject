using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_1.People
{
    public class Student : Human
    {
        private int _mark;

        public Student(string firstName, string lastName, int mark) : base(firstName, lastName)
        {
            Mark = mark;
        }

        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value >= 2 && value <= 6)
                { 
                    _mark = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
