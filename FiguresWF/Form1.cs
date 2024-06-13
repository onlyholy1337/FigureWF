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
                    area = length * width;
                    perimeter = 2 * (length + width);
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
            }
            MessageBox.Show($"Площадь: {area}\nПериметр: {perimeter}");
        }
    }
}
