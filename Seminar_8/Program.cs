// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет 
//            местами первую и последнюю строку массива.

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
//          for(int j = 0; j < columns; j++)
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

// int[,] ChangeRows(int[,] array, int row1, int row2) // Создадаим метод для обмена строк
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
//     // Вложенный цикл не требуется, потому что номер строки известен. 
//     //Для начала запустим проверку if, для проверки соответствия условий
//         for(int j = 0; j < array.GetLength(1); j++ ) // после всех условий запускаем цикл
//                                                 // введем j т.к. будем по элементам столбцов
//         {
//             int temp = array[row1, j]; // созд. временную переменную и записываем первый элемент
//             array [row1, j] = array [row2, j]; // в первый элемент записываем второй
//             array[row2, j] = temp; // во второй записываем временную
//         }
//     return array;
// }

// int[,] myArray = CreateRandom2dArray(); 
// Show2dArray(myArray); 

// Show2dArray(ChangeRows(myArray, 2, 3));

/*--------------------------------------
Задача 2 Задайте двумерный массив. Напишите программу, которая заменяет 
строки на столбцы. В случае, если это невозможно, программа должна 
вывести сообщение для пользователя.
------------------------------------*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRowsOnColumns(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ChangeRowsOnColumns(myArray);
Show2dArray(myArray);