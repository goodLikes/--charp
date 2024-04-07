// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


Console.WriteLine("Введите число 3-ех значное");
int num1 = Convert.ToInt32(Console.ReadLine());
int firstElement = 0;
int fE3 = 0;
int sum = 0;

if (num1 > 99)
{
  if (num1 < 1000)
  {
    firstElement = num1 % 10; // остаток от деления
    fE3 = num1 / 100; // обычное деление

    sum = firstElement + fE3;
  }
  Console.WriteLine(sum);
}

else
{
  Console.WriteLine("Число меньше 99");
  Console.WriteLine("Число больше 999");
}

