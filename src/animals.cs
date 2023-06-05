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

    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Moo!");
        }
    }

    public class Pig : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Oink!");
        }
    }
}