// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] CreateRandomArray(int columns, int rows, int leftRange, int rightRange)           // Метод создания двухмерного массива и заполнения его случайными числами (вещественными)
{
    Random rand = new Random();
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange) * rand.NextDouble();            // Генерация случайного значения элемента массива в заданных границах (положительные)

            double sign = rand.NextDouble();                                                // Генерация случайного значения 

            if (sign > 0.5) matrix[i, j] = matrix[i, j] * -1;                               // Присвоение случайного знака значению

            matrix[i, j] = Math.Round(matrix[i, j], 2);                                     // Округление значения до двух знаков после запятой
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)                                                             // Метод вывода двухмерного массива в консоль
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

// Получить от пользователя кол-во строк и столбцов

int m = EnterNumber("Введите число столбцов: ");
int n = EnterNumber("Введите число строк: ");

// Создать двухмерный массив и зполнить его

double[,] matrix = CreateRandomArray(m, n, 0, 10);

// Вывести массив в консоль

PrintArray(matrix);