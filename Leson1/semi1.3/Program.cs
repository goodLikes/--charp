// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num >= 100)
{
  int res = 0;

  while (num > 1000)
  {
    num = num / 10;
  }
  res = num % 10;
  Console.WriteLine(res);
}

else
{
  Console.WriteLine("Число не подходит");
}