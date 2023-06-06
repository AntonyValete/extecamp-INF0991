using System;
using System.Collections.Generic;

namespace Program
{
    // Define a base class
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }

    // Define derived classes
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

        // Define a generic class
    public class Zoo<T> where T : Animal
    {
        private List<T> animals;

        public Zoo()
        {
            animals = new List<T>();
        }

        public void AddAnimal(T animal)
        {
            animals.Add(animal);
        }

        public void ListAnimals()
        {
            foreach (T animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.MakeSound();
            }
        }

        public IEnumerable<T> GetAnimals()
        {
            return animals;
        }

        // Define a delegate
        public delegate void AnimalHandler<T>(T animal);
    }

}