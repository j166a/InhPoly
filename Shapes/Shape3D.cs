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
        public Cylinder(Circle shape, double height)
            : base(shape)
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
        public Sphere(Circle shape)
            : base(shape)
        {
        }
        public override double CalculateVolume()
        {
            Circle circle = (Circle)BaseShape;
            double radius = circle.Radius;
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
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
