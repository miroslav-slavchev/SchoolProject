using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_1.People
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public int Wage { get; set; }

        public int HoursWorked { get; set; }

        public int CalculateHourlyWage() => Wage / HoursWorked;
    }
}
