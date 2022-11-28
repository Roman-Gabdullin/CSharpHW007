// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество минимальное значение: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество максимальное значение: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[line, columns];
double[] array = new double[columns];
matrix = FillMatrix(matrix, minvalue, maxvalue);
array = ArithmeticMeanOfEachColumn(matrix, array);
PrintMatrix(matrix);
PrintArray(array);

double [] ArithmeticMeanOfEachColumn(int[,] matrix, double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }   
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] = array[j] + matrix[i,j];
        }
        array[j] = array[j] / matrix.GetLength(0);
    }
    return array;
}

int[,] FillMatrix(int[,] matrix,int minvalue,int maxvalue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minvalue, maxvalue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}
