//36  1.Задайте одномерный массив, заполненный случайными числами. 
//    2.Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
int[] CreateArrayRndInt(int size, int min, int max)    //метод создания массива
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)                                  //метод вывода массива со скобками (красивый массив)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");

    }

}

int SumNotChet(int[] arr)                                     //метод пересчета пускай будет ядро
{
    int sum = 0;                                              // счет результата начинается с 0
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];                         //поиск нечетного индекса массива
    }

    return sum;
}


int[] array = CreateArrayRndInt(10, -99, 99);              //интервал  от -99 до 99
int number = SumNotChet(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {number}");