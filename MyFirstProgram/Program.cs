using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Red");
            //car.Start(); // Calls the overridden method in Car class
            //Console.WriteLine(car.make);
            Console.WriteLine(car);

            // using polymorphism to create an array of Vehicle objects
            Vehicle[] vehicles = { new Car("Toyota", "Red"), new Boat(), new Bicycle() };

            Console.WriteLine($"There are currently {Vehicle.GetVehicleCount()} vehicles.");

            Car car2 = Copy(car); // Copying car using the copy method
            ChangeColour(car2, "Blue"); // Changing the colour of the copied car
            Console.WriteLine(car2);

            //outputting using polymorphism
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Start(); // Calls the overridden method based on the actual object type
            }

            Console.ReadKey();
        }
        public static Car Copy(Car car)
        {
            return new Car(car.GetMake(), car.GetColour());
        }

        public static void ChangeColour(Car car, string colour)
        {
            car.SetColour(colour);
        }
    }

    abstract class Vehicle 
    {
        private readonly int baseSpeed = 30; //other classes can no longer change this value
        private static int vehicleCount = 0;
        public Vehicle()
        {
            vehicleCount++;
        }
        public abstract void Start();

        static public int GetVehicleCount()
        {
            return vehicleCount;
        }
    }

    class Car : Vehicle
    {
        private readonly int maxSpeed = 200;
        private string make;
        private string colour;

        public Car(string make, string colour)
        {
            SetMake(make);
            SetColour(colour);
        }
        public override void Start()
        {
            Console.WriteLine("The car is moving at a speed of " + maxSpeed + " km/h.");
        }
        public int GetMaxSpeed()
        {
            return maxSpeed;
        }
        public void SetMake(string make)
        {
            this.make = make;
        }
        public string GetMake()
        {
            return this.make;
        }
        public void SetColour(string colour)
        {
            this.colour = colour;
        }
        public string GetColour()
        {
            return this.colour;
        }
        public override string ToString()
        {
            return $"Car Make: {GetMake()}, Colour: {GetColour()}, Max Speed: {GetMaxSpeed()} km/h";
        }
    }

    class Boat : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The boat is sailing on the water.");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The bicycle is pedaling forward.");
        }
    }

}