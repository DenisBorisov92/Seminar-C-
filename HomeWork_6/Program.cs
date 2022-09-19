/*-------------------------------------------------
Задача 41: Пользователь вводит с клавиатуры M чисел. 
           Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
-------------------------------------------------*/
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите любое целое {i + 1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int ShowNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sum++;
    return sum;
}

Console.Write("Введите число, какой длины будет массив: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
ShowArray(newArray);


Console.Write($"{ShowNumbers(newArray)} числа(-ел) > 0 ввели в массив: ");
