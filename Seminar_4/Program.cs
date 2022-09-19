/*------------------------------------------------------------
Задача 1. Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
-------------------------------------------------------------*/
/*
int SummaInt(int a)
{
    int sum = 0;

    for(int i = 1; i <= a; i++) sum = sum + i;
 
    return sum;
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Cумма чисел от 1 до {num} = {SummaInt(num)}"); 
*/

/*---------------------------------------------------------------
Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
--------------------------------------------------------------*/
/*
int Quantity (int num)
{
    int result = 0;
    while (num > 0)
   { 
    num /= 10;
    result ++;
   }
    return result;
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Quantity of numbers in {n} is {Quantity(n)}");
*/

/*---------------------------------------------------
Задача 3. Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N
---------------------------------------------------*/

int ProductNum (int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++)
    result = result*i;
    return result;
}
Console.Write ("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Product of number {n} is {ProductNum(n)}");