using Enginespace;
using System.Reflection;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car FirstCar = new Car("Bentley", "Phantom", 80, new CarEngine());
            FirstCar.StartEngine();
            FirstCar.Drive();
           
            Car SecondCar = new Car("Nissan", "Skyline", 90,new CarEngine());
            SecondCar.StartEngine();
            SecondCar.Drive();

            Motorcycle FirstCycle = new Motorcycle("Yamaha", "R1", 60, true ,new MotorcycleEngine());
            FirstCycle.StartEngine();
            FirstCycle.Drive();
                
        }
    }
}
