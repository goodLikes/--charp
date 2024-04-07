// Программа сравнивает квадрат числа Console.ReadLine(); - команда ожидания ввода пользователя
// "=" это присвоение "==" это сравнение

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 == num2 * num2)
{
  Console.WriteLine("является квадратом");
}

else
{
  Console.WriteLine("НЕ является квадратом числа");
}



