namespace FiguresWF
{
    public abstract class Figure
    {
        public abstract double GetArea();

        public virtual double Perimetr { get { return 0; } }

        public override string ToString()
        {
            return "Simple Figure";
        }
    }
}
