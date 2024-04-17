﻿void ZeroEvenElements(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      arr[i] = 0;
    }
  }
}

void PrintArray(int[] arr)
{
  foreach (int A in arr)
  {
    Console.Write($"{A} ");
  }
}


int[] array = { 1, 2, 3, 4, 5, 6, 7 };
ZeroEvenElements(array);
PrintArray(array);