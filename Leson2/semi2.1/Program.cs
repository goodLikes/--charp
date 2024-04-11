/* 
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа 
должна выдать ответ: Да / Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да */


System.Console.WriteLine("Введите число");
int userNum = Convert.ToInt32(Console.ReadLine()); // получили от пользователя число

int[] array = new int[6];// создали массив
string isFind = "Net"; // создали изначально "нет"

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 20);// заполнили масив рандомом
  Console.Write(array[i] + " ");//вывод массива

  if (userNum == array[i])// если такой масив появиться мы указываем ДА
  {
    isFind = "da";
  }
}
System.Console.WriteLine(isFind);
