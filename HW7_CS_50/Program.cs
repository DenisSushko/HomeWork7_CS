// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] createArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(201) - 100;
        }
    }
    return arr;
}

void printArray(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int countValues(int[,] arr, int m, int n, int value)
{
    int size = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i, j] == value)
            {
                size++;
            }
        }
    }
    return size;
}

int[] findValue(int[,] arr, int m, int n, int value, int size)
{
    int iter = 0;

    int[] indexes = new int[size * 2];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i, j] == value)
            {
                indexes[iter] = i;
                indexes[iter + 1] = j;
                iter = iter + 2;
            }
        }
    }
    return indexes;
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = createArray(m, n);
printArray(arr, m, n);
Console.WriteLine("Введите число, индекс которого хотите найти:");
int value = int.Parse(Console.ReadLine()!);
int size = countValues(arr, m, n, value);
if (size != 0)
{
    int[] indexes = findValue(arr, m, n, value, size);
    Console.WriteLine("Все найденные индексы:");
    for (int i = 0; i < indexes.Length; i = i + 2)
    {
        Console.WriteLine($"({indexes[i]}, {indexes[i + 1]})");
    }
}
else
{
    Console.WriteLine("Нет элемента с таким значением.");
}
