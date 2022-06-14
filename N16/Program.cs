// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 * number1 == number2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
if(number2 * number2 == number1)
{
    Console.WriteLine("Второе число является квадратом первого");
}
if(number1 * number1 != number2 && number2 * number2 != number1) 
{
    Console.WriteLine("Числа не являются корнями");
}