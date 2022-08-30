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