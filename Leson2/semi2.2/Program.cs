﻿/* Задайте массив из 10 элементов, заполненный числами из 
промежутка [-10, 10]. Замените отрицательные элементы на 
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6] */

int[] array = new int[6]; //cоздали массив

for (int i = 0; i < array.Length; i++) // цикл
{
  array[i] = new Random().Next(-1, 11); // если указывают числа вместо 10 нужно 11
  Console.Write(array[i] + "\t");// табуляция + выводим весь наш массив
}

System.Console.WriteLine(); // что бы не сливались числа

for (int i = 0; i < array.Length; i++)
{
  array[i] = array[i] * -1;// обращение к массиву и умножение его на -1
  Console.Write(array[i] + "\t"); // табуляция
}
