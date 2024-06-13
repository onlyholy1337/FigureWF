namespace FiguresWF
{
    public class Square : Figure
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double Perimetr
        {
            get
            {
                return 4 * Side;
            }
        }

        public override string ToString()
        {
            return $"Square with side {Side}";
        }
    }
}
