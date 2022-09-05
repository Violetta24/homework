// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int numM = InputNumbers("Введите число M: ");
int numN = InputNumbers("Введите число N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int AkermanFun(int numberN, int numberM)
{

    if (numberN == 0)
    {
        return numberM + 1;
    }
    else if ((numberM == 0))
    {
        return AkermanFun(numberN - 1, 1);
    }
    else
    {
        return AkermanFun(numberN - 1, AkermanFun(numberN, numberM - 1));
    }

}

int NatSum = AkermanFun(numM, numN);
Console.WriteLine($"Функции Аккермана, для чисел A({numM},{numN}) Равна: {NatSum}");