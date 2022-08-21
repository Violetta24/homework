//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


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

int Number(int[] arr)                                          //метод пересчета пускай будет ядро
{
    int result = 0;                                          // счет результата начинается с 0
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result = result + 1;       //нахождение четности %2 == 0
    }

    return result;
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

int[] arrya = CreateArrayRndInt(4, 0, 999);
int number = Number(arrya);
PrintArray(arrya);
Console.WriteLine();
Console.WriteLine($"Колличество четных элементов масиива = {number}");
