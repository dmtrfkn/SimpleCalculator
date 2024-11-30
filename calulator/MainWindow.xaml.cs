using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик для кнопок операций
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input1.Text, out double num1) && double.TryParse(Input2.Text, out double num2))
            {
                Button clickedButton = sender as Button;
                string operation = clickedButton.Content.ToString();
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("Ошибка: деление на ноль!");
                        break;
                }

                ResultText.Text = $"Результат: {result}";
            }
            else
            {
                MessageBox.Show("Введите корректные числа.");
            }
        }
    }
}
