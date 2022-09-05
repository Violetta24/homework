// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();

int m = InputNumbers("Введите количество элементов строки m: ");         //
int n = InputNumbers("Введите количество элементов столбцов n: ");       //
int range = InputNumbers("Введите диапазон: от 1 до ");                  //
                                                                         //
int InputNumbers(string input)                                           // Интересный метод ввода данных с консоли
{                                                                        //
    Console.Write(input);                                                  //     
    int output = Convert.ToInt32(Console.ReadLine());                      //  сканируем эту страку на все числа
    return output;                                                         //  присвоеные значения уходит в программу
}                                                                        //


int[,] array = new int[m, n];                                            //Объявление массива                        

void CreateArray(int[,] array)                                           //метод создания массива

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}


int SumLineElements(int[,] array, int i)                                //метод поиска строки с минимальной суммой элементов
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void PrintMatrix(int[,] array)                                          //метод печати массива           
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

CreateArray(array);
PrintMatrix(array);
//-------------------------------------------------------------------------------------------------------------
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);                                   // после нахождения строки с минимальным значением элементов
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;                                                 // находим сумму элементов этой строки
        minSumLine = i;                                                        // показываем строку
    }
}
Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
//-------------------------------------------------------------------------------------------------------------