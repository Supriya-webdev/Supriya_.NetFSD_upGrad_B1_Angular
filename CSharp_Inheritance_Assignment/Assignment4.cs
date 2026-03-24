using System;

namespace C_Inheritance_Assignment
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }

        public void StartVehicle() => Console.WriteLine($"{Brand} {VehicleNumber} started");
    }

    public class Car : Vehicle
    {
        public string FuelType { get; set; }
    }

    public sealed class ElectricCar : Car
    {
    }

    internal class Assignment4
    {
        static void Main()
        {
            ElectricCar ec = new ElectricCar { VehicleNumber = "E123", Brand = "Tesla", FuelType = "Electric" };
            ec.StartVehicle();
            Console.WriteLine(ec.FuelType);
        }
    }
}