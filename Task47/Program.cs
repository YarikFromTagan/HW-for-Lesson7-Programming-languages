/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
Например, задан массив:  m = 3, n = 4.
0,5    7     -2    -0,2
 1   -3,3     8    -9,9
 8    7,8   -7,1     9
*/

double[,] Create2DArray()
{
    Console.WriteLine("Для создания двумерного массива размером m х n,");
    Console.WriteLine("заполненного случайными вещественными числами");
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
    
    double [,] arr = new double[str, stlb];
    for(int i = 0; i < str; i++)
    {
        for(int j = 0; j < stlb; j++)
        {
            double intPart = new Random().Next(min, max+1);
            double fractPart = new Random().NextDouble();
            arr[i, j] = intPart + fractPart;
        }
    } 
    return arr;
}

void Print2DArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]:f1}     ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
double [,] Array = Create2DArray();

Print2DArray(Array);