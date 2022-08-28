// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


void Sum(double b_1, double k_1, double b_2, double k_2)
{
double x = 0;
double y = 0;
x = (b_2 - b_1)/(k_1 - k_2);
y = Math.Round(k_1 * x + b_1, 1);
Console.Write($"Точка пересечения двух прямых (|x {x} : y {y}|)");
}

Sum(b1, k1, b2, k2);