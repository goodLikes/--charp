// Создаем функцию под 2-умерный масив и заполняем его случайными числами в матрице

int[,] CreateMatrix(int rowCount, int columCount)
{
  int[,] matrix = new int[rowCount, columCount];

  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

      matrix[i, j] = rnd.Next(1, 11);
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

      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
