using System;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Добавление опций фигур в combobox
            figure_comboBox.Items.Add("Прямоугольник");
            figure_comboBox.Items.Add("Окружность");
            figure_comboBox.Items.Add("Квадрат");
            figure_comboBox.Items.Add("Треугольник");
            figure_comboBox.Items.Add("Трапеция");
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            double area = 0;
            double perimeter = 0;
            switch (figure_comboBox.SelectedItem.ToString())
            {
                case "Прямоугольник":
                    double length = (double)size1_numericUpDown.Value;
                    double width = (double)size2_numericUpDown.Value;
                    Rect rectangle = new Rect(length, width);
                    area = rectangle.GetArea();
                    perimeter = rectangle.Perimetr;
                    break;
                case "Окружность":
                    double radius = (double)size1_numericUpDown.Value;
                    Circle circle = new Circle(radius);
                    area = circle.GetArea();
                    perimeter = circle.Perimetr;
                    break;
                case "Квадрат":
                    double side = (double)size1_numericUpDown.Value;
                    Square square = new Square(side);
                    area = square.GetArea();
                    perimeter = square.Perimetr;
                    break;
                case "Треугольник":
                    double baseLength = (double)size1_numericUpDown.Value;
                    double height = (double)size2_numericUpDown.Value;
                    double sideA = baseLength; // Assuming an equilateral triangle for simplicity
                    double sideB = baseLength; // Assuming an equilateral triangle for simplicity
                    Triangle triangle = new Triangle(baseLength, height, sideA, sideB);
                    area = triangle.GetArea();
                    perimeter = triangle.Perimetr;
                    break;
                case "Трапеция":
                    double base1 = (double)size1_numericUpDown.Value;
                    double base2 = (double)size2_numericUpDown.Value;
                    double heightTrap = (double)size1_numericUpDown.Value;
                    double sideATrap = (double)size2_numericUpDown.Value;
                    double sideBTrap = (double)size1_numericUpDown.Value;
                    Trapezoid trapezoid = new Trapezoid(base1, base2, heightTrap, sideATrap, sideBTrap);
                    area = trapezoid.GetArea();
                    perimeter = trapezoid.Perimetr;
                    break;
            }
            MessageBox.Show($"Площадь: {area}\nПериметр: {perimeter}");
        }
    }
}
