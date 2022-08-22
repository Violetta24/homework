// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8




// int number = ReadInt("Введите число: ");
// int a = 0;
// int b = 1;
// int i = 0;
// Console.Write($"{a} {b} ");
// while(i < number -2)
// {    
//     int temp = b;
//     b = a + b;
//     a = temp;    
//     i++;
//     Console.Write(b + " ");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// ***********************************************************************************************************************************************

int size = ReadInt("Сколько чисел Фиббоначи вывести?: ");
int[] numbersFibonacci = new int[size];
if (size > 0)
    numbersFibonacci[0] = 0;
if (size > 1)
    numbersFibonacci[1] = 1;

for (int i = 2; i < numbersFibonacci.Length; i++)
{
    numbersFibonacci[i] = numbersFibonacci[i - 1] + numbersFibonacci[i - 2];
}
PrintArray(numbersFibonacci);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
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






