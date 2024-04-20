/// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4


int[,] CreateArray()
{
  int[,] arracks = new int[3, 8];
  return arracks;
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

void ChangeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0)
      {
        array[i, j] = array[i, j] * array[i, j];
      }
    }
  }
}

int[,] numbers = CreateArray();

FillingArray(numbers);
PrintArray(numbers);
ChangeArray(numbers);

System.Console.WriteLine();
PrintArray(numbers);