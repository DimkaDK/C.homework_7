// SЗадача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int columns, int rows, int leftRange, int rightRange)               // Метод создания двухмерного массива и заполнения его случайными числами
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)                                                               // Метод вывода двухмерного массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" " + matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindAverageInColumnsInArray(int[,] matrix)                                                     // Метод поиска среднего арифметического элементов в каждом столбце
{
    Console.WriteLine("В массиве: ");
    PrintArray(matrix);
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        sum = sum / matrix.GetLength(0);
        Console.WriteLine($"В столбце № {j + 1} среднее арифметическое элементов равно {sum}");
        sum = 0;
    }
}

// Получить от пользователя кол-во строк и столбцов

int columns = EnterNumber("Введите число столбцов: ");
int rows = EnterNumber("Введите число строк: ");

// Создать двухмерный массив и зполнить его

int[,] matrix = CreateRandomArray(columns, rows, 0, 10);

// Поиск среднего арифметического по столбцам

FindAverageInColumnsInArray(matrix);