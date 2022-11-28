// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// {0,5 |   7  |  -2  | -0,2}

// { 1  | -3,3 |   8  | -9,9}

// { 8  |  7,8 | -7,1 |   9 }



Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество минимальное значение: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество максимальное значение: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[line, columns];
array = FillArray(array, minvalue, maxvalue);
PrintArray(array);



double[,] FillArray(double[,] array,int minvalue,int maxvalue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(minvalue*100, maxvalue*100)) / 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}