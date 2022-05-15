using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog sounds");
        }
    }
}
