using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Animals
{
    public abstract class Animal
    {
        private int _age;
        public Animal(string name, int age, Gender gender)
        {
            Name = name;
            _age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid age.");
                }
            }
        }

        public Gender Gender { get; set; }

        public void PrintData()
        {
            Console.WriteLine($"Name:{Name},Age:{Age},Gender:{Gender}");
        }

        public abstract void MakeSound();
    }
}
