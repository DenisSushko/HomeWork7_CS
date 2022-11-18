// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] avgCol(int [,] arr, int m, int n) {
    double[] avgColumn = new double[n];
    for(int i = 0; i < n; i++) {
        avgColumn[i] = 0;
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            avgColumn[i] += arr[j, i];
        }
        avgColumn[i] = Math.Round(avgColumn[i] / m, 2);
    }

    return avgColumn;
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = createArray(m, n);
printArray(arr, m, n);
double[] avg =  avgCol(arr, m, n);
Console.WriteLine("Среднее арифметическое каждого столбца:");
for(int i = 0; i < n; i++) {
    Console.Write(avg[i] + "; ");
}