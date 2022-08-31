/*
// Задача 1. Текст задачи.
 Необходимо написать программу которая на вход принимает число и выдает его квадрат

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;
Console.WriteLine($"Quad of {number} is {kvadrat}"); */

// Задача 2. Текст задачи.
// Напишите программу, которая на вход принимает два числа 
//и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} is a quad of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not a quad of {num2}");
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно 
// число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/* Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three-digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.Write($"last digit of {num} it is {result}");
*/