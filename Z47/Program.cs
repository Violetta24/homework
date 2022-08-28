//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateMatrixDouble(int m, int n)                                      // метод двумерного массива
{
    double[,] arr = new double[m, n];                                             // метод двумерного массива

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();                    //диапазон - 10 до 10 

        }
    }
    return arr;
}


void PrintMatrix(double[,] arr)                                                                  //метод печати вещественого двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");

            if (j < arr.GetLength(1) - 1) Console.Write($"{Math.Round(arr[i, j], 1),7}|");   //обрезание 0,1 после запяттой
            else Console.Write($"{Math.Round(arr[i, j], 1),7}|");                             //обрезание 0,1 после запяттой
        }
        Console.WriteLine();
    }
}

double[,] arrayResult = CreateMatrixDouble(3, 4);

Console.WriteLine("Двумерный массив размером m * n, заполненный случайными вещественными числами");
Console.WriteLine("_________________________________");
PrintMatrix(arrayResult);
Console.WriteLine("---------------------------------");