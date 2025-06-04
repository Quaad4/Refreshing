using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit hops away quickly!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk swoops down to catch its prey!");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away swiftly!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish waits patiently for its prey.");
        }
    }
}