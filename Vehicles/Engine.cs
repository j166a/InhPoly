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
        bool Running { get; set; }
        int Horsepower { get; set; }
        FuelTypeEnum FuelType { get; set; }

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
            : base(600, FuelTypeEnum.Unleaded)
        {

        }
    }

    public class MotorcycleEngine : Engine
    {
        public MotorcycleEngine()
            : base(1000, FuelTypeEnum.Leaded)
        {

        }
    }

    





}