using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            double number1;
            //number1 = double.Parse(number1TextBox.Text);
            double.TryParse(number1TextBox.Text, out number1);
            double number2;
            number2 = double.Parse(number2TextBox.Text);

            //double result = number1+ number2;
            //resultTextBox.Text = result.ToString
            string result;
            result = Convert.ToString(number1 + number2);

            resultTextBox.Text = result;
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            number1 = double.Parse(number1TextBox.Text);

            double number2;
            number2 = double.Parse(number2TextBox.Text);

            string result;
            result = Convert.ToString(number1 * number2);

            resultTextBox.Text = result;
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            number1 = double.Parse(number1TextBox.Text);

            double number2;
            number2 = double.Parse(number2TextBox.Text);

            string result;
            result = Convert.ToString(number1 - number2);

            resultTextBox.Text = result;
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            number1 = double.Parse(number1TextBox.Text);

            double number2;
            number2 = double.Parse(number2TextBox.Text);

            string result;
            result = Convert.ToString(number1 / number2);

            resultTextBox.Text = result;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            number1TextBox.Clear();
            number2TextBox.Clear();
            resultTextBox.Clear();
        }
    }
}