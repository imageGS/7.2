using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Radius { get; set; }
        public bool IsCheckBoxSquare { get; set; }
        public bool IsCheckBoxLenght { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (IsCheckBoxLenght == true & IsCheckBoxSquare == false) MessageBox.Show($"Lenght of the circle = {Math.Round((2 * Math.PI * Radius),2)} cm", "Calculation");
            else if (IsCheckBoxSquare == true & IsCheckBoxLenght == false) MessageBox.Show($"Square of the circle = {Math.Round((Math.PI * Math.Pow(Radius, 2)),2)} cm^2", "Calculation");
            else if (IsCheckBoxSquare == true & IsCheckBoxLenght == true) MessageBox.Show($"Square of the circle = {Math.Round((Math.PI * Math.Pow(Radius, 2)),2)} cm^2 \nLenght of the circle = {Math.Round((2 * Math.PI * Radius),2)} cm", "Calculation");
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            Input input = new Input();
            input.Show();
            this.Close();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            if (Radius <= 12)
            {
                gridDraw.Visibility = Visibility.Visible;
                circle.Height = (Radius * 2) * 10;
                circle.Width = circle.Height;
            }
            else MessageBox.Show("The figure cannot be drawn. The radius is too large.");
        }

        private void winMain_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsCheckBoxSquare == true || IsCheckBoxLenght == true)
            {
                btnDraw.IsEnabled = true;
                btnCalc.IsEnabled = true;
            }
            else
            {
                btnDraw.IsEnabled = false;
                btnCalc.IsEnabled = false;
            }
        }
    }
}
