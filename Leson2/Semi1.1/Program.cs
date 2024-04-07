// Программа на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N  до N
// Primer :  4 => -4 , -3 , -2 , -1 , 0 , 1 , 2, 3, 4

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int NegativeNum = -num1;

while (NegativeNum <= num1)
{
  Console.Write(NegativeNum + " ");
  // или Console.WriteLine(NegativeNum);
  NegativeNum++;
}
