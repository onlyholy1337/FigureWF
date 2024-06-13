namespace FiguresWF
{
    public class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB)
        {
            Base = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public override double Perimetr
        {
            get
            {
                return Base + SideA + SideB;
            }
        }

        public override string ToString()
        {
            return $"Triangle with base {Base}, height {Height}, sideA {SideA}, and sideB {SideB}";
        }
    }
}
