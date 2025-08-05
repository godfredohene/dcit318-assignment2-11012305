using System;

namespace AbstractApp
{
    // Abstract class
    abstract class Animal
    {
        public abstract void MakeSound();  // Abstract method (no body)
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof! Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();  // Calls overridden method
            myDog.Eat();        // Calls inherited non-abstract method

            Console.ReadLine();
        }
    }
}
