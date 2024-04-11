int[] array = new int[6];

/* int i = 0;
while (i < 6)
{
  i++;
} */
for (int i = 0; i < 3; i++)
{
  array[i] = new Random().Next(1, 10); // можно указать nextdouble() и будет не целые числа
  Console.WriteLine(array[i] + " ");
}


