﻿//int n = 10;
int[] arr = new int[n];//либо тут поставить N и работать через первый вариант
int i = 0;

//while (i < n)  можно так пользоваться для поиска ,а можно вот так
while (i < arr.Length)
{
  arr[i] = i + 1;
  //Console.Write(arr[i]);
  //Console.Write(' ');
  Console.Write($"{arr[i]} "); // или такая команда для вывода в одну строку масивов
  i = i + 1;
}