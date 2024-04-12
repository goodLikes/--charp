// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

int num = new Random().Next(100, 1000); // 256
Console.WriteLine(num);

int num1 = num / 100; // 2 - что бы получить перву цифру
int num3 = num % 10; // 6 - что бы получить 3 цифру

int result = num1 * 10 + num3; // 2+6 =8 если не умножить на *10 то будет 8 а не 26

//или можно было в одну строчку int result = num/100*10+num%10;

//Console.WriteLine(result);
//Console.WriteLine(num/100*10+num%10);
//можно и так

Console.WriteLine(num1 + " privet " + num3); //конькитинация
Console.WriteLine($"{num1} hello {num3}"); // интерполяция/