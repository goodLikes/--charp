// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет " + num1 % num2);
}