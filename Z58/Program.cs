// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int m = InNum("Введите число строк 1-й матрицы: ");
int n = InNum("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InNum("Введите число столбцов 2-й матрицы: ");
int range = InNum("Введите диапазон случайных чисел: от 1 до ");

int InNum(string input)                                                //метод для ввода
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)                                 // метод создания матрицы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range) + 1;              // (+1) исключаем 0
        }
    }
}

int[,] firstMartrix = new int[m, n];                              //вывод 1 - й матрицы
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
Printarray(firstMartrix);

int[,] secomdMartrix = new int[n, p];                             //вывод 2 - й матрицы
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
Printarray(secomdMartrix);

int[,] resultarray = new int[m, p];

void Multiplyarray(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultarray)   //метод умножения 2 - х матриц
{
    for (int i = 0; i < resultarray.GetLength(0); i++)
    {
        for (int j = 0; j < resultarray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultarray[i, j] = sum;
        }
    }
}

Multiplyarray(firstMartrix, secomdMartrix, resultarray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Printarray(resultarray);



void Printarray(int[,] array)                                          //метод печати массива           
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4} | ");
            else Console.Write($"{array[i, j],4} | ");
        }
        Console.WriteLine();
    }
}