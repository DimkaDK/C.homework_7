// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Вариант решения, если мы ищем элемент по его индексам


Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int columns, int rows, int leftRange, int rightRange)                    // Метод создания двухмерного массива и заполнения его случайными числами
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

void FindElementInArray(int[,] matrix)                                                     // Метод поиска элемента в массиве по заданным индексам
{
    int flag = 0;
    int indexI = EnterNumber("Введите i индекс элемента: ");
    int indexJ = EnterNumber("Введите j индекс элемента: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == indexI & j == indexJ)
            {
                Console.WriteLine("В массиве: ");
                PrintArray(matrix);
                Console.WriteLine($"Элемент с индексами [{indexI}, {indexJ}] равен: {matrix[indexI, indexJ]}");
                flag = 1;
            }
        }
    }
    if (flag == 0)
    {
        Console.WriteLine("В массиве: ");
        PrintArray(matrix);
        Console.WriteLine($"Элемент с индексами [{indexI}, {indexJ}] отсутствует");
    }
}

// Получить от пользователя кол-во строк и столбцов

int m = EnterNumber("Введите число столбцов: ");
int n = EnterNumber("Введите число строк: ");

// Создать двухмерный массив и зполнить его

int[,] matrix = CreateRandomArray(m, n, 0, 10);

// Вывести массив в консоль

PrintArray(matrix);

// Поиск элемента в массиве по индексам

FindElementInArray(matrix);