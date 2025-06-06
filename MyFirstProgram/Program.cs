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
            Console.WriteLine($"There are currently {Vehicle.GetVehicleCount()} vehicles.");

            // using polymorphism to create an array of Vehicle objects
            List<Vehicle> vehicles = new List<Vehicle> { new Car("Toyota", "Red"), new Boat(), new Bicycle() };

            Console.WriteLine($"There are currently {Vehicle.GetVehicleCount()} vehicles.");

            Car car2 = Copy(car); // Copying car using the copy method
            Console.WriteLine($"There are currently {Vehicle.GetVehicleCount()} vehicles.");

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
            return new Car(car.Make, car.Colour);
        }

        public static void ChangeColour(Car car, string colour)
        {
            car.Colour = colour;
        }
    }

    abstract class Vehicle 
    {
        private const int baseSpeed = 30; //other classes can no longer change this value
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

    class Car(string make, string colour) : Vehicle
    {
        private readonly int maxSpeed = 200;
        public string Make { get; set; } = make;
        public string Colour { get; set; } = colour;

        public override void Start()
        {
            Console.WriteLine("The car is moving at a speed of " + maxSpeed + " km/h.");
        }
        public int GetMaxSpeed()
        {
            return maxSpeed;
        }
        public override string ToString()
        {
            return $"Car Make: {Make}, Colour: {Colour}, Max Speed: {GetMaxSpeed()} km/h";
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