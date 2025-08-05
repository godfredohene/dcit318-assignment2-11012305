using System;

namespace InterfacesApp
{
    // Define an interface
    interface IAnimal
    {
        void MakeSound();
    }

    // Implement the interface
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat says: Meow! Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myCat = new Cat();
            myCat.MakeSound();

            Console.ReadLine();
        }
    }
}
