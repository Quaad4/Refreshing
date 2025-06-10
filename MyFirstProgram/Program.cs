using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car = new(4);
            Car car2 = new(4);
            Car car3 = new(3);

            Bike bike = new();
            Truck truck = new();
            Aeroplane aeroplane = new();
            Boat boat = new();

            Vehicle[] vehicles = { car, bike, truck, aeroplane, boat };
            Car[] cars = { car, car2, car3 };

            //foreach(Vehicle vehicle in vehicles)
            //{
            //    vehicle.Move();
            //}

            //CountNumberOfWheels(car);

            string[] names = { "Alice", "Bob", "Charlie" };
            int[] numbers = { 1, 2, 3, 4, 5 };
            double[] prices = { 9.99, 19.99, 29.99 };

            Output(names);
            Output(numbers);
            Output(prices);
            Output(cars);

            Console.ReadKey();
        }


        public static void CountNumberOfWheels(Vehicle vehicle)
        {
            Console.WriteLine($"This vehicle has {vehicle.wheels} wheels");
        }

        public static void Output<T>(T[] items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    abstract class Vehicle
    {
        private const int maxSpeed = 500;

        public int wheels = 0;
        public abstract void Move();
    }
    
    class Car : Vehicle
    {
        public Car(int wheels)
        {
            this.wheels = wheels;
        }
        public override void Move()
        {
            Console.WriteLine("The car is moving at a speed of 100 km/h.");
        }

        public override string ToString()
        {
            return $"This is a car with {wheels} wheels";
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