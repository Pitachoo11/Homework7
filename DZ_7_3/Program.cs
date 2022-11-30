// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void AbsByColumn(int[,] inArray)
{
    double summ = 0;
    double abs = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        summ = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            summ += inArray[j,i];
        }
        
        abs = Math.Round(summ/inArray.GetLength(0), 2);
        //Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое столбца {i} = {abs} ");
        //Console.WriteLine();
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10); // 0,10 - это min и max диапазона заполнения случайными числами 

PrintArray(array);

AbsByColumn(array);