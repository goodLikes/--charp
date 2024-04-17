// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillingArray()
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 10);
  }
}

void PrintArray()
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
}

int GetNumInArray()
{
  int result = 0;

  for (int i = 0; i < array.Length; i++)
  {
    bool isFind = true;

    for (int j = 2; j < array[i]; j++)
    {
      if (array[i] % j == 0)
      {
        isFind = false;
        break;
      }
    }

    if (isFind)
    {
      result = result + 1;
    }
  }

  return result;
}

FillingArray();
PrintArray();
System.Console.WriteLine("Число= " + GetNumInArray());