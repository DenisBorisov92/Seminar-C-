// Задача. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int [,] CreateRandom2dArray() // созд.метод двумерного массива, арг. не будем указывать, для красоты, все их укажем и присвоим в методе
// {
//     Console.Write("Input numbers of rows: "); // т.к. не берем аргументы вначале, нужно все нужные аргументы запросить.
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];  // выделаем память под двумерный массив
     
//     for(int i = 0; i < rows; i++) // Сейчас заполняем его(массив), при помощи вложенного цикла
//     {                             // внеш. цикл закидывает на опр строку, а внутр прогоняет по элементам строки
//         for(int j = 0; j < columns; j++)  // внутр цикл для столбцов
//             array[i,j] = new Random().Next(minValue, maxValue + 1); // заполнение элемента массива.
//     }  
//     return array;    // Вернем наш массив
//                    // Новое для нас: то что мы арг. не запрашиваем а вводим прямо в методе
//                    // и то что для заполнения массива нам нужно исп вложенный цикл
// }

// void Show2dArray(int[,] array)   // метод отображения массива, здесь уже будет аргумент
// {
//     for (int i = 0; i < array.GetLength(0); i++) // отображает только строки припомощи (GetLength)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // 
//            Console.Write(array[i,j] + " ");
        
//         Console.WriteLine(); // перенос на новую строку(переход), далее выводим след строку и тт.д.
//     }
//     Console.WriteLine();
// }      

// int[,] myArray = CreateRandom2dArray(); // созд новый массив,и поместим туда наш метод, аргументов нет потому что мы их записали внутри метода
// Show2dArray(myArray); // Вызываем метод Show , для отображения массива

/*-----------------------------------------------------------------------
Задача 2. Задайте двумерный массив размера m на n, каждый элемент в массиве 
          находится по формуле: Aij = i+j. Выведите полученный массив на экран.
---------------------------------------------------------------------*/

// int[,] MatrixSumIndex()
// {
//     Console.Write("Input numbers of rows: "); 
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int[,] arr = new int[rows,columns];
//     for(int i = 0; i< rows; i++)
//         for (int j = 0; j < columns; j++)
//             arr[i,j] = i+j;
            
//     return arr;
// }
// void Show2dArray(int[,] array)   // метод отображения массива, здесь уже будет аргумент
// {
//     for (int i = 0; i < array.GetLength(0); i++) // отображает только строки припомощи (GetLength)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // 
//            Console.Write(array[i,j] + " ");
        
//         Console.WriteLine(); // перенос на новую строку(переход), далее выводим след строку и тт.д.
//     }
//     Console.WriteLine();
// }      

// int[,] myArray = MatrixSumIndex(); 
// Show2dArray(myArray); 


/*---------------------------------------------------------
Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
-------------------------------------------------------*/

int [,] CreateRandom2dArray() 
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
     
    for(int i = 0; i < rows; i++) 
    {                             
        for(int j = 0; j < columns; j++) 
            array[i,j] = new Random().Next(minValue, maxValue + 1); 
    }  
    return array;    
                  
}

void Show2dArray(int[,] array)   
{
    for (int i = 0; i < array.GetLength(0); i++) // отображает только строки припомощи (GetLength)
    {
        for (int j = 0; j < array.GetLength(1); j++) // 
           Console.Write(array[i,j] + " ");
        
        Console.WriteLine(); // перенос на новую строку(переход), далее выводим след строку и тт.д.
    }
    Console.WriteLine();
}      
// int[,] ChangeEvensToSquareMatrix (int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i+=2)
//         for (int j = 0; j < arr.GetLength(1); j+=2)
//             arr[i,j] = arr[i,j]*arr[i,j]; //Math.Pow(arr[i,j], 2)
//     return arr;   
// }

int[,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray);
// myArray = ChangeEvensToSquareMatrix(myArray);
// Show2dArray(myArray);

/*-------------------------------
Задайте двумерный массив. Найдите сумму элементов, находящихся на 
             главной диагонали (с индексами (0,0); (1;1) и т.д.
-----------------------------------------*/

int SumMainDiag(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
    {
        sum+= matrix[i,i];
    }
    return sum;
}
Console.WriteLine($"сумма элементов главной диагонали {SumMainDiag(myArray)}");