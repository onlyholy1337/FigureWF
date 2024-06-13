using System;

namespace FiguresWF
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimetr
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }
}
