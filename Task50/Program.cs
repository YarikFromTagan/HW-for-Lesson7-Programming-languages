/*
Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
              1 7 -> такого числа в массиве нет
*/


int[,] Create2DArray()
{
    Console.WriteLine("Для создания двумерного массива размером m х n,");
    Console.WriteLine("заполненного случайными целыми числами");
    Console.WriteLine();

    Console.Write("Введите количество строк создаваемого массива: m = ");
    int str = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов создаваемого массива: n = ");
    int stlb = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное значение создаваемого массива: min = ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное значение создаваемого массива: max = ");
    int max = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    
    int [,] arr = new int[str, stlb];
    for(int i = 0; i < str; i++)
    {
        for(int j = 0; j < stlb; j++) arr[i, j] = new Random().Next(min, max+1);
    } 
    return arr;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j]}   ");
    Console.WriteLine();
    }
    Console.WriteLine();
}

void FindNumber(int[,] arr)
{
    Console.WriteLine("Двумерный массив создан");
    Console.WriteLine();

    Console.Write("Введите номер строки искомого элемента i = ");
    int i = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца искомого элемента j = ");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if(i > arr.GetLength(0) || j > arr.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет,");
        Console.WriteLine($"так как размер созданного массива [{arr.GetLength(0)} x {arr.GetLength(1)}]");
    } 
    else Console.WriteLine($"В заданном квадрате находится число {arr[i-1, j-1]}");
    Console.WriteLine();

}

Console.Clear();
int [,] Array = Create2DArray();

FindNumber(Array);

Print2DArray(Array);