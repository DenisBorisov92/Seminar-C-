/*------------------------------------------------------
Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
-----------------------------------------------------*/
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
int[] ReverseArray (int[] array)
{
    for (int i = 0,j= array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
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
ShowArray(ReverseArray(newArray));
*/
/*--------------------------------------------------
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
--------------------------------------------------*/
/*
string ConvertTo2 (int a)
{
    string res = string.Empty;
    while (a != 0)
    {
        res = a % 2 + res;
        a = a / 2;
    }
    return res;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string res = ConvertTo2(num);
Console.WriteLine($"Двоичное число числа {num} равно {res}");
*/

/*---------------------------------------
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b.
------------------------------------*/

int[] Fibon(int num1, int num2, int kol)
{
    int [] arr = new int [kol];
    arr[0] = num1;
    arr[1] = num2;
    for(int i = 2; i < kol; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1]; 
    }
    return arr;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите первое число из ряда: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число из ряда: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Какое количество чисел ряда Фибоначчи отоброзить: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibon(a, b, n));