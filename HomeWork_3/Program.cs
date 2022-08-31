/*-------------------------------------------------------
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
------------------------------------------------------*/
/*
void Polindrom(int num)
{
   
int digit1 = num / 10000;
int digit2 = num % 10000 / 1000;
int digit4 = num % 100 / 10;
int digit5 = num % 10;
if(digit1 == digit5 && digit2 == digit4)
{Console.WriteLine("Yes");}
    
else
{Console.WriteLine("No");}
}
int num = new Random().Next(10000, 100000);
Console.WriteLine("Is this a palindrome? " + num);
Polindrom(num);
*/
/*-------------------------------------------------------
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
------------------------------------------------------*/
/*
double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x1 - x2;
    double dy = y1 - y2;
    double dz = z1 - z2;
    double dist = Math.Sqrt(dx*dx + dy*dy + dz*dz);
    return dist;
}
Console.WriteLine("Введите координаты первой точки x, y and z:");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки x, y and z:");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Double otrezok = Distance(x1, y1, z1, x2, y2, z2);
Console.Write($"Длина отрезка между точками равна: {otrezok}");
*/
/*-------------------------------------------------------
Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
------------------------------------------------------*/
void TableCubes(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"куб числа {i} = {i*i*i}");
        i++;
    }
}
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableCubes(num);