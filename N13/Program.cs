﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int a, b, c, d;
Console.WriteLine("Введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());

b = a / 100; //первое число
c = a / 10 % 10; //второе число
d = a % 10; //третье число

if (a > 99 && a < 1000)
{
Console.WriteLine($"Третья цифра числа {d}");
}
else
{
Console.WriteLine("Вы ввели неверное число");
}