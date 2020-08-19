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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public char c;

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '0';
        }

        private void Double_zero_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "00";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '1';
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '2';
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '3';
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '4';
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '5';
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '6';
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '7';
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '8';
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += '9';
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += ',';
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text = "";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(text_box.Text);
                c = '+';
                text_box.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(text_box.Text);
                c = '-';
                text_box.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(text_box.Text);
                c = '*';
                text_box.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(text_box.Text);
                c = '/';
                text_box.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(text_box.Text);
            text_box.Text = "";

            switch (c)
            {
                case '+':
                    text_box.Text = Convert.ToString(a + b);
                        break;
                case '-':
                    text_box.Text = Convert.ToString(a - b);
                        break;
                case '*':
                    text_box.Text = Convert.ToString(a * b);
                        break;
                case '/':
                    text_box.Text = Convert.ToString(a / b);
                        break;
            }
        }
    }
}
