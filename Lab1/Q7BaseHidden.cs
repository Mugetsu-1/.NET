using System;

namespace BaseKeywordHiddenApp
{
    
    class Animal
    {
        public string name = "Wild Animal";
        public int legs = 4;

        public void Display()
        {
            Console.WriteLine($"Base Class - Name: {name}, Legs: {legs}");
        }

        public void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }


    class Dog : Animal
    {
       
        public new string name = "Domestic Dog";
        public new int legs = 4;

        public new void Sound()
        {
            Console.WriteLine("Dog barks: Woof! Woof!");
        }

        public void ShowAll()
        {
            Console.WriteLine("USING DERIVED CLASS MEMBERS");
            Console.WriteLine($"Derived Class - Name: {name}, Legs: {legs}");
            Sound();

            Console.WriteLine("\nUSING BASE CLASS MEMBERS (via base)");
            Console.WriteLine($"Base Class - Name: {base.name}, Legs: {base.legs}");
            base.Sound();

            Console.WriteLine("\nUSING BASE CLASS METHOD");
            base.Display();
        }
    }
}