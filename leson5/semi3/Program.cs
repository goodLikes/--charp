// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

Console.WriteLine("Введите строчку");
string userInput = Console.ReadLine();

userInput = userInput.ToLower();

string vowels = "aeiouy";
int count = 0;

for (int i = 0; i < userInput.Length; i++)
{
  if (vowels.Contains(userInput[i]))
  {
    count++;
  }
}
System.Console.WriteLine(count);

