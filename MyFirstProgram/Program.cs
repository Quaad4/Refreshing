using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Red");
            //car.start(); // Calls the overridden method in Car class
            //Console.WriteLine(car.make);
            Console.WriteLine(car);

            // using polymorphism to create an array of Vehicle objects
            Vehicle[] vehicles = { new Car("Toyota", "Red"), new Boat(), new Bicycle() };

            Console.WriteLine($"There are currently {Vehicle.getVehicleCount()} vehicles.");

            //outputting using polymorphism
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.start(); // Calls the overridden method based on the actual object type
            }

            Console.ReadKey();
        }
    }

    abstract class Vehicle 
    {
        int speed;
        protected static int vehicleCount = 0;
        public Vehicle()
        {
            vehicleCount++;
        }
        public virtual void start()
        {
            Console.WriteLine("The vehicle is moving.");
        }
        static public int getVehicleCount()
        {
            return vehicleCount;
        }
    }

    class Car : Vehicle
    {
        protected int maxSpeed = 200;
        protected String make;
        protected String colour;

        public Car(String make, String colour)
        {
            setMake(make);
            setColour(colour);
        }
        public override void start()
        {
            Console.WriteLine("The car is moving at a speed of " + maxSpeed + " km/h.");
        }
        public int getMaxSpeed()
        {
            return maxSpeed;
        }
        public void setMake(String make)
        {
            this.make = make;
        }
        public String getMake()
        {
            return this.make;
        }
        public void setColour(String colour)
        {
            this.colour = colour;
        }
        public String getColour()
        {
            return this.colour;
        }
        public override string ToString()
        {
            return $"Car Make: {getMake()}, Colour: {getColour()}, Max Speed: {getMaxSpeed()} km/h";
        }
    }

    class Boat : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("The boat is sailing on the water.");
        }
    }

    class Bicycle : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("The bicycle is pedaling forward.");
        }
    }

}