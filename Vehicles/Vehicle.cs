using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enginespace;

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
            Engine.Start();
        }

    }

    public class Car : Vehicle
    {
        public Car(string make, string model, int speed, Engine engineType)
            : base(make, model, speed, engineType)
        {

        }
    }

    public class Motorcycle : Vehicle
    {

        string HasSideCar { get; set; }
        public Motorcycle(string make, string model, int speed, string hasSideCar, Engine engineType)
            : base(make, model, speed, engineType)
        {
            HasSideCar = hasSideCar;
        }

    }




}