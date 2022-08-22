// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
int inputNumber = ReadInt("Введите число: ");
int baseNumber = 2;
int number = inputNumber;
int size = 0;

while(number > 0)
{
    size++;
    number /= baseNumber;
}

int[] result = new int[size];
number = inputNumber;
for(int i = 0; i < result.Length; i++)
{
    // result[result.Length - 1 - i] = number % baseNumber;   запись массива с конца
    number /= baseNumber;
}
PrintArray(result);


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}




// ***************************************************************************


// int number = ReadInt("Введите число: ");
// int baseNumber = 2;
// string result = string.Empty;

// while(number > 0)
// {
//     result = number % baseNumber + result;
//     number /= baseNumber;
// }
// Console.WriteLine(result);


// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
