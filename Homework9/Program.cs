using Homework9.Animals;
using Homework9.Animals.Cats;
using System;
using System.Collections.Generic;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Kitten("Felix", 2, Gender.Male),
                new Tomcat("Tom", 2, Gender.Male),
                new Dog("Rex", 2, Gender.Male),
                new Frog("Frog", 2, Gender.Female)
            };

            foreach(Animal animal in animals)
            {
                animal.PrintData();
                animal.MakeSound();
            }
        }
    }
}
