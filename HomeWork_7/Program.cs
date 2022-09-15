/*-----------------------------------------------------------
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
-------------------------------------------------------*/

double [,] CreateRandomDouble2dArray()
{
    Console.Write("Input numbers of rows: "); // т.к. не берем аргументы вначале, нужно все нужные аргументы запросить.
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];  
     
    for(int i = 0; i < rows; i++) 
    {                             
        for(int j = 0; j < columns; j++)  
            array[i,j] = Math.Round((new Random().Next(minValue, maxValue + 1) + 
            new Random().NextDouble()),3); 
    }  
    return array;    
}

void Show2dArray(double[,] array)   
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) // 
           Console.Write(array[i,j] + " ");
        
        Console.WriteLine(); 
    }
    Console.WriteLine();
}      

double[,] myArray = CreateRandomDouble2dArray(); 
Show2dArray(myArray); 

/*----------------------------------------------------------
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
           арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
------------------------------------------------------*/

// int [,] CreateRandom2dArray() 
// {
//     Console.Write("Input numbers of rows: "); 
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];  

//     for(int i = 0; i < rows; i++) 
//     {                             
//         for(int j = 0; j < columns; j++)  
//             array[i,j] = new Random().Next(minValue, maxValue + 1); 
//     }  
//     return array;    
// }

// void Show2dArray(int[,] array)   
// {
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//            Console.Write(array[i,j] + " ");
        
//         Console.WriteLine(); 
//     }
//     Console.WriteLine();
// }      
// void ArithmeticMeanEachColumn (int[,] array)
// {

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         double res = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i,j];
//             res = Math.Round(sum / array.GetLength(1),2);
//         }
//     Console.WriteLine($"Среднее арифметическое {j+1} столбца: {res}; ");
//     }
// }

// int[,] myArray = CreateRandom2dArray(); 
// Show2dArray(myArray); 

// ArithmeticMeanEachColumn(myArray);