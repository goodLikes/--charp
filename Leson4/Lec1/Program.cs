/// Создание в двумерном массиве матрицу математическую
double[,] matrix = new double[3, 5];

Random rnd = new Random(); // лучше в цикл не ствить , потому что ресурсоемкая команда

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {

    matrix[i, j] = rnd.Next(1, 11);
  }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} "); // интерполяция строк
  }
  Console.WriteLine();
}
