using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginespace
{
    public enum FuelTypeEnum
    {
        Unleaded,
        Leaded,
        Diesel
    }
    public abstract class Engine
    {
        public bool Running { get; set; }
        public int Horsepower { get; set; }
        public FuelTypeEnum FuelType { get; set; }

        public Engine(int horsepower, FuelTypeEnum fuelType)
        {
            Running = false;
            Horsepower = horsepower;
            FuelType = fuelType;

        }

        public void Start()
        {
            Running = true;
        }
    }

    public class CarEngine : Engine
    {
        public CarEngine()
            : base(60, FuelTypeEnum.Unleaded)
        {}
    }

    public class MotorcycleEngine : Engine
    {
        public MotorcycleEngine()
            : base(10, FuelTypeEnum.Leaded)
        {

        }
    }

}