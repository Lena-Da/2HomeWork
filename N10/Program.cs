// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int a, b, c, d;
Console.WriteLine("Введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());

b = a / 100;
c = a / 10 % 10;
d = a % 10;

Console.WriteLine(c);