/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void ArithmeticAverage(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sumStlb = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sumStlb = (sumStlb + arr[i, j]);
        }
        
        double average = sumStlb / arr.GetLength(0);
        Console.Write ($"{average:f2}  ");
    }

}

Console.Clear();
int [,] Array = Create2DArray();

Print2DArray(Array);

ArithmeticAverage(Array);




