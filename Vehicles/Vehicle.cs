using Enginespace;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Engine EngineType { get; set; }

        public Vehicle(string make, string model, int speed, Engine engineType)
        {
            Make = make;
            Model = model;
            Speed = speed;
            EngineType = engineType;
        }

        public void StartEngine()
        {
            EngineType.Start();
        }
        public void Drive()
        {
            if(EngineType.Running)
            {
                Accelerate();
            }
            Console.WriteLine($"{Make} {Model} is not running.");
        }
        protected abstract void Accelerate();
        
    }
    public class Car : Vehicle
    {
        public Car(string make, string model, int speed, Engine engineType)
            : base(make, model, speed, engineType)
        {}
        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                FuelTypeEnum.Unleaded => 1.5D,
                FuelTypeEnum.Leaded => 1.2D,
                FuelTypeEnum.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2):F2}mph");
            }
        }
    }

    public class Motorcycle : Vehicle
    {

        bool HasSideCar { get; set; }
        public Motorcycle(string make, string model, int speed, bool hasSideCar, Engine engineType)
            : base(make, model, speed, engineType)
        {
            HasSideCar = hasSideCar;
        }
        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                FuelTypeEnum.Unleaded => 1.5D,
                FuelTypeEnum.Leaded => 1.2D,
                FuelTypeEnum.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (HasSideCar ? 0.8 : 1.0)}mph");
            }
        }
}




}