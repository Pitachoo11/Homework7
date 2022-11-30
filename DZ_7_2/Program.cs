// Задача 50: Напишите программу, которая на вход
// принимает значение и
// возвращает позиции этого элемента в массиве или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void CheckNumberPresence(int[,] inArray, int number)

{
    bool result = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j] == number)
            {
                result = true;
                System.Console.WriteLine();
                System.Console.WriteLine($"Найденный индекс числа {number}: {i}, {j}");
                break;
            }
        }
    }
    if (result == false)
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Число {number} в массиве не найдено");
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

Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10); // 0,10 - это min и max диапазона заполнения случайными числами 

PrintArray(array);

CheckNumberPresence(array, number);