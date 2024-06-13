namespace FiguresWF
{
    public class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Trapezoid(double base1, double base2, double height, double sideA, double sideB)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
            SideA = sideA;
            SideB = sideB;
        }

        public override double GetArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public override double Perimetr
        {
            get
            {
                return Base1 + Base2 + SideA + SideB;
            }
        }

        public override string ToString()
        {
            return $"Trapezoid with bases {Base1}, {Base2}, height {Height}, sideA {SideA}, and sideB {SideB}";
        }
    }
}
