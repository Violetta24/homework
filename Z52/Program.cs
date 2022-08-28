// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 


Console.Clear();        

int[,] CreateMatrixRndInt(int m, int n, int min, int max)   
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}


void PrintMatrix(int[,] arr)                                              
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 4} | ");
            else Console.Write($"{arr[i, j], 4} | ");
        }
        Console.WriteLine();
    }
}

void Plus(int[,] arr)
{
for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sr = 0;
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            sr = sr + arr[j, i]; 
        }
        sr = sr / arr.GetLength(0);

        Console.WriteLine($"Среднее арифметическое {i+1}  столбца, равна ({Math.Round(sr, 1)})"); 
      

    }
 
}

int[,] array = CreateMatrixRndInt(3, 4, 0, 10);
Console.WriteLine("____________________________");
PrintMatrix(array);
Console.WriteLine("----------------------------");
Plus(array);