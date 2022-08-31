/* ------------------------------------------------------------------------------
Задача 1.  Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
-------------------------------------------------------------------------------*/
/*
int FindQuadrant (double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    
    return 0;
}

Console.Write("Введите координаты Х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Y: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA );

if (xA==0 || yA==0)
   {
        Console.WriteLine("Point lie on axis");
   } 
else
{
    Console.WriteLine($"Number of quadrant is {quadrant}");
}
// добавили к решению ввод сообщение, когда точка лежит на оси.
*/

/*----------------------------------------------------------------------------
Задача 2.
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
---------------------------------------------------------------------------*/
/*
void CoorByQuadrant(int quadrant)
{
    string output = "Некорректный ввод данных";
    if (quadrant ==1)
    {output = $"Для четверти {quadrant} x > 0 y > 0";}
    if (quadrant ==2)
    {output = $"Для четверти {quadrant} x < 0 y > 0";}
    if (quadrant ==3)
    {output = $"Для четверти {quadrant} x < 0 y < 0";}
    if (quadrant ==4)
    {output = $"Для четверти {quadrant} x > 0 y < 0";}
    Console.WriteLine(output);
}
Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
CoorByQuadrant(num);
*/

/* ---------------------------------------------------
Задача 3. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
----------------------------------------------------*/
/*
void TableSquares(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"квадрат числа {i} = {i*i}");
        i++;
    }
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableSquares(num);
*/

/* ------------------------------------
Задача 4.  Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 2D пространстве.
----------------------------------------*/

double Length(double x1, double y1, double x2, double y2)
{
    double dx = x1 - x2;
    double dy = y1 - y2;
    double len = Math.Sqrt(dx*dx + dy*dy);
    return len;
}
Console.Write("Введите координату х1: ");
Double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
Double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
Double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
Double y2 = Convert.ToDouble(Console.ReadLine());

double len = Length(x1, y1, x2, y2);
Console.Write($"Длина отрезка ({x1},{y1}) ({x2},{y2}) ровняется {len}");
// а можно так  Console.Write($"Длина отрезка ({x1},{y1}) ({x2},{y2}) ровняется {length(x1, y1, x2, y2)}");
//в этом варианте записале более компактно, пропустив присваивание.