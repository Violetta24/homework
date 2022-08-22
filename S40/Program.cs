// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int sideA = ReadInt("Введите длину стороны A: ");
int sideB = ReadInt("Введите длину стороны B: ");
int sideC = ReadInt("Введите длину стороны C: ");

bool isCheckSideA = sideA < sideB + sideC;
bool isCheckSideB = sideB < sideA + sideC;
bool isCheckSideC = sideC < sideB + sideA;

if(isCheckSideA && isCheckSideB && isCheckSideC)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
