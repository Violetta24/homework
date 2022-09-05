// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int numM = InputNumbers("Введите число M: ");
int numN = InputNumbers("Введите число N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int SumNaturalNumber(int numberM, int numberN)
{

    if (numberM > numberN) return 0;
    {
        return numberM + SumNaturalNumber(numberM + 1, numberN);
    }
}
int NatSum = SumNaturalNumber(numM, numN);
Console.WriteLine($"Сумма всех натуральных чисел в итервале {numM} и {numN} равна {NatSum}");