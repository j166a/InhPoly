using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape3D
    {
        public Shape BaseShape { get; set; }

        public Shape3D(Shape baseShape)
        {
            BaseShape = baseShape;
        }

        public abstract double CalculateVolume();
    }

    public class Cylinder : Shape3D 
    {
        public double Height { get; set; }

        public Cylinder(Circle baseShape, double height)
            : base(baseShape)
        {
            Height = height;
        }

        public override double CalculateVolume()
        {
            
            return BaseShape.CalculateArea() * Height;
        }
    }
    public class Cone : Shape3D 
    {
        public double Height { get; set; }
        public Cone(Circle shape, double height)
            : base(shape)
        {
            Height = height;
        }

        public override double CalculateVolume()
        {
            return (BaseShape.CalculateArea() * Height) / 3;
        }
    }

    public class Sphere : Shape3D
    {
        public Sphere(Circle baseShape)
            : base(baseShape)
        {
        }
        public override double CalculateVolume()
        {
            Circle circle = (Circle)BaseShape;
            double radius = circle.Radius;

            Console.WriteLine(radius);
            Console.WriteLine(Math.Pow(5, 3) * Math.PI * (4 / 3));

            return (Math.Pow(radius, 3) * Math.PI * (4 / 3));
        }
    }

    public class Pyramid : Shape3D
    {
        public double Height { get; set; }
        public Pyramid(Triangle shape, double height)
            : base(shape)
        {
            Height = height;
        }
        public override double CalculateVolume()
        {
            return (BaseShape.CalculateArea() * Height) / 3;
        }
    }

    public class Prism : Shape3D
    {
        public double Height { get; set; }
        public Prism(Triangle shape, double height)
            : base(shape)
        {
            Height = height;
        }
        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }


}
