// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]


Console.WriteLine("ВВедите число:   ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
FillArray(array);
PrintArray(array);