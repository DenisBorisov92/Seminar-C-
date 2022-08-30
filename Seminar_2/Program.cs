//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
//показывает наибольшую цифру числа.
/*
int FindBiggerDigit(int number) // void
{
    int ed = number % 10;
    int dec = number / 10;

    int result;
    if(ed > dec) result = ed;
    else result = dec;

    return result;  // эту строчку можно будет удалить
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}"); */

// Задача 2. Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
/*
int Pack(int num)
{ 
    int high, low, res;

    high = num/100;
    low = num % 10;
    res = high*10 + low;
    return res;
}

int randNum = new Random().Next (100, 1000);
int doublNum = Pack(randNum);

Console.WriteLine ($"Из трехзначного числа {randNum} получаем двухзначное {doublNum}");
*/
/*--------------------------------------------------------------------------------
 Задача 3. Напишите программу, которая будет принимать на вход два числа и 
 выводить, является ли второе число кратным первому. 
 Если второе число не кратно числу первому, то программа выводит остаток от деления.
---------------------------------------------------------------------------------*/
/*
void CheckNumbers(int a, int b)
{
    int res=b%a;
    if(res==0)
        Console.WriteLine("Второе число кратно превому");
    else
        Console.WriteLine($"Остаток от деления второго числа на первое ={res}");
}

Console.WriteLine("Программа проверки числа на кратность второго к первому");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

CheckNumbers(a, b); */

/* -----------------------------------------------------------------------------
Задача 3.  Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 7 и 23.
 -------------------------------------------------------------------------------*/

 bool CheckNumbers(int x, int a, int b)
 {
    if((x%a==0)&(x%b==0))
        return true;
    else return false;
 }

 Console.WriteLine("Проверка на кратность числа двум другим");

 Console.Write("Введите число для проверки: ");
 int x = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите первое условие кратности: ");
 int a = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите второе условие кратности: ");
 int b = Convert.ToInt32(Console.ReadLine());
 
 bool result = CheckNumbers(x, a, b);

 if(result)
    Console.WriteLine($"Число {x} кратно числу {a} и числу {b}");
else
    Console.WriteLine($"Число {x} некратно числу {a} и числу {b}");


