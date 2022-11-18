// Задача HARD SORT необязательная. Считается за три обязательных 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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

int[,] sortArray(int[,] arr, int m, int n)
{
    int[,] result = arr;
    for (int i = m * n - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (result[j / n, j % n] > result[i / n, i % n])
            {
                int temp = result[j / n, j % n];
                result[j / n, j % n] = result[i / n, i % n];
                result[i / n, i % n] = temp;
            }
        }
    }
    return result;
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = createArray(m, n);
printArray(arr, m, n);
int[,] sortedArr = sortArray(arr, m, n);
Console.WriteLine("Отсортированный массив:");
printArray(sortedArr, m, n);
