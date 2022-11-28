// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество минимальное значение: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество максимальное значение: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс элемента по строкам: ");
int searchIndexLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс элемента по столбцам: ");
int searchIndexColumns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[line, columns];
array = FillArray(array, minvalue, maxvalue);
PrintArray(array);
SearchMatrix(array, searchIndexLine, searchIndexColumns);



void SearchMatrix(int[,] array,int searchIndexLine, int searchIndexColumns)
{
    if (searchIndexLine > array.GetLength(0)
        || searchIndexColumns > array.GetLength(1)
        || searchIndexLine < 0
        || searchIndexColumns <0) 
        Console.Write("Такого элемента в массиве нет");
        else Console.Write($"Значение введенного элемента массива = {array[searchIndexLine,searchIndexColumns]}");
}

int[,] FillArray(int[,] array,int minvalue,int maxvalue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minvalue, maxvalue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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