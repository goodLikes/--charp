// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

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
  string result = "";

  for (int i = 0; i < array.Length; i++)
  {
    result = result + array[i];
  }

  return int.Parse(result);
}

FillingArray();
PrintArray();
System.Console.WriteLine("Число= " + GetNumInArray());