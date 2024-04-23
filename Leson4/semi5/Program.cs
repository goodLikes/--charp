//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

System.Console.Write("Введите число :");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillingArray()
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);

  }
  Console.WriteLine("Массив до переворота: ");
}

void PrintArray()
{
  for (int i = 0; i < array.Length; i++)

  {
    Console.Write(array[i] + " ");
  }
}

void ReverseArray()
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    int reverso = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = reverso;
  }
}

FillingArray();
PrintArray();

ReverseArray();
Console.WriteLine("\n======================");
Console.WriteLine("Массив после переворота:");
PrintArray();

