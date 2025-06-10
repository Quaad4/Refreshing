using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car = new();
            Bike bike = new();
            Truck truck = new();
            Aeroplane aeroplane = new();
            Boat boat = new();

            Vehicle[] vehicles = { car, bike, truck, aeroplane, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Move();
            }

            CountNumberOfWheels(vehicles);

            Console.ReadKey();
        }

        public static void CountNumberOfWheels<T>(T[] vehicles)
        {
            foreach (T vehicle in vehicles)
            {
                Console.WriteLine($"This vehicle has {vehicle} wheels.");
            }
        }
    }

    abstract class Vehicle
    {
        private const int maxSpeed = 500;

        protected int wheels = 0;

        public abstract void Move();
    }
    
    class Car : Vehicle
    {
        public Car()
        {
            this.wheels = 4;
        }
        public override void Move()
        {
            Console.WriteLine("The car is moving at a speed of 100 km/h.");
        }
    }

    class Bike : Vehicle
    {
        public Bike()
        {
            this.wheels = 2;
        }
        public override void Move()
        {
            Console.WriteLine("The bike is moving at a speed of 20 km/h.");
        }
    }

    class Truck : Vehicle
    {
        public Truck()
        {
            this.wheels = 4;
        }
        public override void Move()
        {
            Console.WriteLine("The truck is moving at a speed of 80 km/h.");
        }
    }

    class Aeroplane : Vehicle
    {
        public Aeroplane()
        {
            this.wheels = 3;
        }
        public override void Move()
        {
            Console.WriteLine("The aeroplane is flying at a speed of 500 km/h.");
        }
    }

    class Boat : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The boat is sailing at a speed of 30 km/h.");
        }
    }
}