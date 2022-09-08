/*-------------------------------------------------------------
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
---------------------------------------------------------------*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue);

    return newArray;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
        sum = sum + array[i];
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.Write($"Sum of negative elements is {FindNegativeSum(newArray)}");
*/

/*-------------------------------------------------------------
Напишите программу для замены элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
----------------------------------------------------------*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue);

    return newArray;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int[] Change(int[]array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
        array[i] = array[i]*(-1);
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.WriteLine("replace signs in array");
ShowArray(Change(newArray));
*/

/*-------------------------------------------------
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
-----------------------------------------------*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue);

    return newArray;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
bool WasFound(int [] a, int num)
{
    for(int i = 0; i < a.Length; i++)
        if (a[i] == num)
        return true;
    return false;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input any number: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

if (WasFound(newArray, num))
    Console.WriteLine("Number is present");
else
    Console.WriteLine("Number is absent");
*/
/*------------------------------------------
Задайте одномерный массив из 15 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99].
-------------------------------------------------*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue);

    return newArray;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int QuantityElements(int[] a,int min, int max)
{
    int res = 0;
    for (int i = 0;i < a.Length;i++)
       { 
        if ((a[i] >= min) && (a[i] <= max))
    res++;
       }
    return res;
        }

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min scope of monitoring range: ");
int minTest = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max scope of monitoring range: ");
int maxTest = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.Write($"The number of elements within monitoring range: {QuantityElements(newArray,minTest,maxTest)}");