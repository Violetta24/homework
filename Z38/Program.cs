//Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();

double[] CreateArrayRndInt(int size, int min, int max)                               //метод создания массива вещ чисел
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max) + rnd.NextDouble();
    }
    return arr;
}


double Raznica(double[] arr)                                                          //метод пересчета пускай будет ядро
{
    double maxNum = 0;
    double minNum = 0;                                                               // счет результата начинается с 0
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
        if (arr[i] < minNum) minNum = arr[i];
    }

    double raz = maxNum - minNum;
    return raz;

}


void PrintArray(double[] arr)                                                       //метод вывода массива со скобками (красивый массив)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(Math.Round(arr[i], 2) + ",  ");       //Math.Round - обрезание после заапятой (переменная, индекс)
        else Console.Write(Math.Round(arr[i], 2) + "]");                            //Math.Round - обрезание после заапятой (переменная, индекс)

    }

}

double[] array = CreateArrayRndInt(4, -99, 99);              //интервал  от -99 до 99
PrintArray(array);                                           // вывод
Console.WriteLine();
double sumF = Raznica(array);
Console.WriteLine($"разница между между максимальным и минимальным элементами: {Math.Round(sumF, 3)}");
