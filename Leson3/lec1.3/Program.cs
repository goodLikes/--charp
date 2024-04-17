/* //Заполнение массива через терминал

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
  Console.WriteLine("Введите элемент массива (целое число): ");
  string input = Console.ReadLine();
  arr_int[i] = Convert.ToInt32(input);
  i++;
}
 */

// Заполнение масива через Рандом ЧИСЕЛ

Random rnd = new Random();

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
  arr_int[i] = rnd.Next(1, 11);
  i++;
}

i = 0;
while (i < size)
{
  Console.Write($"{arr_int[i]} ");
  i++;
}
