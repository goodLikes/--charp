// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4



int[,] array = new int[4, 4];
double[] array2 = new double[array.GetLength(0)];

void FillingArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {

    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 20);
    }
  }
}

void PrintArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}

void GetSumInArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
    }

    array2[i] = sum / array.GetLength(1);
  }
}

void Print()
{
  System.Console.WriteLine();

  for (int i = 0; i < array2.Length; i++)
  {
    System.Console.Write(array2[i] + " ");
  }
}

FillingArray();
PrintArray();
GetSumInArray();
Print();