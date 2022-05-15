using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
