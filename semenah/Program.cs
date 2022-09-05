// Console.WriteLine("Введите числа через запятую: ");
// string input = Console.ReadLine();

// int[] numbers = ParseStringToArray(input);
// PrintArray(numbers);

// int[] ParseStringToArray(string input)
// {
//     int countNumbers = GetCountNumbersInString(input);
//     int[] numbers = new int[countNumbers];
//     int indexNumber = 0;
//     string substring = string.Empty;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] != ',')
//         {
//             substring += input[i];
//         }
//         else
//         {
//             numbers[indexNumber] = Convert.ToInt32(substring);
//             indexNumber++;
//             substring = string.Empty;
//         }
//     }
//     if(input[input.Length - 1] != ',')
//         numbers[indexNumber] = Convert.ToInt32(substring);
//     return numbers;
// }
// int GetCountNumbersInString(string input) 
// {
//     int count;
//     if(input[input.Length - 1] == ',')
//         count = 0;
//     else
//         count = 1;
    
//     for(int i = 0; i < input.Length; i++)
//     {
//         if(input[i] == ',')
//             count++;
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }


//*********************************************************************************************************

// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int[rows, columns];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-5, 9);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// ************************************************************************************************************************

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int ReadInt (string message)
// {
//     Console.Write (message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i+j;
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// /*---------------MAIN--------*/

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int [rows,cols];
// FillArray2D(numbers);
// PrintArray2D(numbers);



// *****************************************************************************************


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 
// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int [,] array = new int [rows,columns];

// FillArray2D(array);
// PrintArray2D(array);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1);j++)
//     {
//         if (i % 2 ==1 && j % 2 ==1)
//         {
//             array [i,j] *= array[i,j]; 
//         }

//     }
    
// }
// PrintArray2D(array);

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt (string message)
// {
//     Console.Write (message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// ********************************************************************************************************************************************

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int rowsNumber = ReadInt("Введите количество строк: ");
// int columnsNumber = ReadInt("Введите количество столбцов: ");
// int[,] arrayNumbers = new int[rowsNumber, columnsNumber];
// int sumElements = 0;

// FillArray2D(arrayNumbers);

// for (int i = 0; i < arrayNumbers.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayNumbers.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sumElements += arrayNumbers [i,j];
//         }
//     }
// }

// PrintArray2D(arrayNumbers);
// Console.WriteLine (sumElements);

// void FillArray2D(int[,] arrayNumbers)
// {
//     for (int i = 0; i < arrayNumbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayNumbers.GetLength(1); j++)
//         {
//             arrayNumbers[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] aarrayNumbers)
// {
//     for (int i = 0; i < arrayNumbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayNumbers.GetLength(1); j++)
//         {
//             Console.Write(arrayNumbers[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");

// int[,] numbers = new int[rows, columns];
// FillArray2D(numbers);
// PrintArray2D(numbers);
// int sum = 0;

// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");

// int[,] numbers = new int[rows, columns];
// FillArray2D(numbers);
// PrintArray2D(numbers);
// int sum = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if(i == j)
//         {
//             sum += numbers[i, j];
//             break;
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine(sum);

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 9);
//         }
//     }
// }
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// ***********************************************************************************************************************

// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int[rows, columns];
// FillArray(numbers);
// PrintArray(numbers);

// int firstRow = 0;
// int secondRow = numbers.GetLength(0) - 1;

// for (int i = 0; i < numbers.GetLength(1); i++)
// {
//     int temp = numbers[firstRow, i];
//     numbers[firstRow, i] = numbers[secondRow, i];
//     numbers[secondRow, i] = temp;
// }
// PrintArray(numbers);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("\n");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// ****************************************************************************************************************

// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int[rows, columns];
// FillArray(numbers);
// PrintArray(numbers);

// if(rows != columns)
// {
//     Console.WriteLine("Транспонировать невозможно!");
//     return;
// }

// int[,] reverseNumbers = new int[numbers.GetLength(1), numbers.GetLength(0)];
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         reverseNumbers[i, j] = numbers[j, i];
//     }
// }
// PrintArray(reverseNumbers);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("\n");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// Задача 57: Составить 
// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+" ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,columns];
for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
PrintArray(array);
int max = array[0, 0];
for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        if (array[i, j] > max) max = array[i, j];
    }
}
int[] counter = new int[max];
for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        counter[array[i, j]-1] += 1;
    }
}
for (int i=0; i<counter.Length; i++)
{
    if (counter[i] == 0) continue;
    Console.WriteLine($"Число {i+1} встречается {counter[i]} раз(а)");
}






