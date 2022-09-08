/*--------------------------------------------------------
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
           Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
---------------------------------------------------------*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1);

    return newArray;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} " );

    Console.WriteLine();
}
int Quantity(int[] a)
{
    int res = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] % 2 == 0 )
        res ++;
    }
    return res;
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.Write($"quantity even numbers is {(Quantity(newArray))}");
*/

/*--------------------------------------------------------
Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
--------------------------------------------------------------*/
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
int SumOddElements( int[] arr)
{
    int res = 0;
    for(int i = 1; i < arr.Length; i = i +2)
        res = res + arr[i];
    return res;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.Write($"Sum of elements placed in odd positions is {SumOddElements(newArray)} ");