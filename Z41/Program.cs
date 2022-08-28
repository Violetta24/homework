//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("ВВедите размер массива");
int z = int.Parse(Console.ReadLine());            //размер массива

int f = 0;
int[] array = new int[z];

int[] Index(int[] array, int z, int f)     //метод ввода чисел
{
    f = 0;
    do
    {
        if (f < z)
        {
            int p = z;
            Console.WriteLine($"Введите число");
            array[f] = int.Parse(Console.ReadLine());
            f++;
        }
    } while (f < z);
    return array;
}


int[] CopyArray(int[] arr)                            //тут храню массив
{
    int size = arr.Length;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i];

    }
    return newArr;
}

void PrintArray(int[] arr)                                  //метод вывода массива со скобками (красивый массив)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("{ ");
        if (i < arr.Length - 1) Console.Write(arr[i] + " | ");
        else Console.Write(arr[i] + " }");

    }

}

int Number(int[] arr)                                        //метод пересчета пускай будет ядро
{
    int result = 0;                                          // счет результата начинается с 0
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result = result + 1;                 //нахождение количества чисел, больше 0
    }

    return result;
}

Index(array, z, f);

int[] newArray = CopyArray(array);
Console.WriteLine();
PrintArray(newArray);

int number = Number(array);
Console.WriteLine();
Console.WriteLine($"Колличество элементов больше 0 = {number}");