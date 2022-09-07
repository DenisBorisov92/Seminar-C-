/*---------------------------------------------------------------
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
--------------------------------------------------------------*/
/*
int Stepen(int a, int b)
{
    int res = 1;
    int count = 0;
    while(count < b)
   {
    res = res * a;
    count++;
   } 
    return res;
}
Console.Write("Input integer A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Stepen(a,b);
Console.WriteLine($"Число {a} в степени {b} = {result}");
*/
/*------------------------------------------------------------
 Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
--------------------------------------------------------------*/
/*
int Summa(int num)
{
    int n = num;
    int sum = 0;
    while (n > 0)
        {
            sum = sum + n %10;
            n = n /10;
        }
    return sum;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum = Summa(number);
Console.WriteLine($"Sum of integers {number} is {Sum}");
*/
/*---------------------------------------------------
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
           и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
--------------------------------------------------------*/
int [] CreateArray (int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
    Console.WriteLine($"Введите число с индексом {i} для массива из 8 элементов: ");
    arr [i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]},");
    Console.Write("\b");
    Console.Write("]");
}
int[] newArray = CreateArray(8);

PrintArray(newArray);


