using System;

class Program
{
  static void Main()
  {
    int n = 10;
    int[] arr = new int[n];
    FillArray(arr);
    PrintArray(arr);
    int sum = GetSumOfElements(arr);
    int product = GetProductOfElements(arr);
    Console.WriteLine(sum);
    Console.WriteLine(product);
  }

  static void FillArray(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = i + 1; // Заполняем массив числами от 1 до n
    }
  }

  static void PrintArray(int[] arr)
  {
    foreach (int num in arr)
    {
      Console.Write(num + " ");
    }
    Console.WriteLine();
  }

  static int GetSumOfElements(int[] arr)
  {
    int sum = 0;
    foreach (int num in arr)
    {
      sum += num;
    }
    return sum;
  }

  static int GetProductOfElements(int[] arr)
  {
    int product = 1;
    foreach (int num in arr)
    {
      product *= num;
    }
    return product;
  }
}