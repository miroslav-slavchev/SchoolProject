using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_1.People
{
    public class Worker : Human
    {
        private double _wage;
        private int _hoursWorked;

        public Worker(string firstName, string lastName, double wage, int hoursWorked) : base(firstName, lastName)
        {
            Wage = wage;
            HoursWorked = hoursWorked;
        }

        public double Wage
        {
            get { return _wage; }
            set
            {
                if (value > 0)
                {
                    _wage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int HoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                if (value >= 0)
                {
                    _hoursWorked = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public double CalculateHourlyWage() => Wage / HoursWorked;
    }
}
