// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

int[,] CreateArray()
{
  int[,] matrix = new int[4, 4];
  return matrix;
}

void FillingArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {

    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 20);
    }

  }

}


void PrintArray(int[,] array)
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

int GetSumInArray(int[,] array)
{
  int count = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
      {
        count = count + array[i, j];
      }
    }
  }
  return count;
}

int[,] numbers = CreateArray();

FillingArray(numbers);
PrintArray(numbers);
System.Console.WriteLine("Сумма =" + GetSumInArray(numbers));