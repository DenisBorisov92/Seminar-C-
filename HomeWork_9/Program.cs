/*Задача 3. Задайте значения M и N. Напишите программу,
       которая выведет все натуральные числа в промежутке от M до N.
-------------------------------------*/

// void ShowNums (int m, int n)
// {
//     Console.Write(m + " ");
//     if (m < n)
//     ShowNums (m+1, n);
//     if (n < m) ShowNums (m-1, n);
// }
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());
// ShowNums (min, max);

/*----------------------------------------
Задача 66: Задайте значения M и N. Напишите программу,
           которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
-----------------------------------------*/

int SumofNums (int m, int n)
{
    if (m < n)
    return SumofNums (m+1, n) + m;
    return m;
}
Console.Write(SumofNums(3, 5));