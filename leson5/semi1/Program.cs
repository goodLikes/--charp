// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 

char[] array = new char[] { 't', '7', ';', 'р' };

string str = "";

// for (int i = 0; i < array.Length; i++)
// {
//     str =str+ array[i];
// }

foreach (var rt in array)
{
  str = str + rt;
}

System.Console.WriteLine(str);