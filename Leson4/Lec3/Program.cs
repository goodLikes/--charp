// Создать двумерный массив, состоящий из целых чисел. Вывести на экран "инетерсные" элементы массива.

int[,] CreateMatrix(int rowCount, int columCount)
{
  int[,] matrix = new int[rowCount, columCount];

  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

      matrix[i, j] = rnd.Next(1, 1111);
    }
  }
  return matrix;
}

void ShowMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

      System.Console.Write($"{matrix[i, j]} " + "/ ");

    }

    System.Console.WriteLine();
  }
  System.Console.Write("========================  ");

}


int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int A in matrix)
{
  if (IsInteresting(A) == true)// можно без == true
  // IS пишем когда выполняем А ЕСЛИ А ЧТО БУДЕТ?
  {
    System.Console.WriteLine(A);
  }

}

bool IsInteresting(int value)
{
  int sumOfDigits = GetSumOfDigits(value);
  /* if (sumOfDigits % 2 == 0)
  {
    return true;
  }
  else
  {
    return false;
  } */
  return sumOfDigits % 2 == 0;
  // -Этот код делает то же самое, что и ваш исходный код, но в более сжатой форме. Он возвращает true, если sumOfDigits четное, и false в противном случае.

}

int GetSumOfDigits(int value)
{
  int sum = 0;
  while (value > 0)
  {
    sum = sum + value % 10;
    value = value / 10;
  }
  return sum;

}
