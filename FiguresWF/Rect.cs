namespace FiguresWF
{
    public class Rect : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rect(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double Perimetr
        {
            get
            {
                return 2 * (Length + Width);
            }
        }

        public override string ToString()
        {
            return $"Rectangle with length {Length} and width {Width}";
        }
    }
}
