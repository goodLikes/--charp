/* Найдите произведения пар чисел в одномерном массиве. Парой 
считаем первый и последний элемент, второй и предпоследний и 
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары) */


System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());// задаем размер масива

int[] array = new int[size];
int[] array2 = new int[size / 2]; //второй массив будет всегда в два раза меньше первого массива пример берем2 элемента , а записываем 1


for (int i = 0; i < array.Length; i++) // цикл 1 массива 1
{
  array[i] = new Random().Next(-10, 11);
  Console.Write(array[i] + "\t");
}

System.Console.WriteLine();

for (int i = 0; i < array2.Length; i++)// второй цикл второго массива
{
  array2[i] = array[i] * array[array.Length - 1 - i];
  Console.Write(array2[i] + "\t");
}
