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
using System.Windows.Shapes;

namespace _7._2
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public Input()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbInput.Text))
                {
                    if (cbLenght.IsChecked == true & cbSquare.IsChecked == false)
                    {
                        MainWindow window = new MainWindow();
                        window.Radius = Convert.ToDouble(tbInput.Text);
                        window.IsCheckBoxSquare = false;
                        window.IsCheckBoxLenght = true;
                        window.Show();
                        this.Close();
                    }
                    else if (cbSquare.IsChecked == true & cbLenght.IsChecked == false)
                    {
                        MainWindow window = new MainWindow();
                        window.IsCheckBoxSquare = true;
                        window.IsCheckBoxLenght = false;
                        window.Radius = Convert.ToDouble(tbInput.Text);
                        window.Show();
                        this.Close();
                    }
                    else if (cbSquare.IsChecked == true & cbLenght.IsChecked == true)
                    {
                        MainWindow window = new MainWindow();
                        window.IsCheckBoxSquare = true;
                        window.IsCheckBoxLenght = true;
                        window.Radius = Convert.ToDouble(tbInput.Text);
                        window.Show();
                        this.Close();
                    }
                    else MessageBox.Show("Please select one of the calculation options.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else MessageBox.Show("Please enter the radius.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the correct radius.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
