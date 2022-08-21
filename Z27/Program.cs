// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("ВВедите число:   ");
int num = Convert.ToInt32(Console.ReadLine());

int SumN(int num)
{

    int counter = Convert.ToString(num).Length;   //смотрим длинну
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = num - num % 10;                    // число делим на 10 
        result = result + (num - advance);
        num = num / 10;
    }

    return result;
}
int sumN = SumN(num);
Console.WriteLine("Сумма цифр в числе: " + sumN);