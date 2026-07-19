using System;

namespace PolymorphismApp
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("RUNTIME POLYMORPHISM\n");

            // Creating array of base class references
            Animal[] animals = new Animal[5];

            // Assigning derived class objects to base class references
            animals[0] = new Dog("Buddy");
            animals[1] = new Cat("Whiskers");
            animals[2] = new Bird("Tweety");
            animals[3] = new Snake("Kaa");
            animals[4] = new Dog("Max");

            // Demonstrating runtime polymorphism
            Console.WriteLine("All Animals Making Sounds");
            foreach (Animal animal in animals)
            {
                animal.MakeSound();  // Calls overridden method based on actual object type
            }

            Console.WriteLine("\nAll Animals Moving");
            foreach (Animal animal in animals)
            {
                animal.Move();  // Calls overridden method based on actual object type
            }

            Console.WriteLine("\nNon-Virtual Method (No Polymorphism)");
            foreach (Animal animal in animals)
            {
                animal.Eat();  // Calls base class method (not overridden)
            }
        }
        */
    }
}