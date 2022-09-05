// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();


int num = InputNumbers("Задайте число: ");

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}



NaturalNumber(num);               

void NaturalNumber(int num)         //число какое ввел пользователь
{
  if(num == 0) return;

   Console.Write($"{num}, ");        //5 4 3 2 1    
   NaturalNumber(num - 1);          
  // Console.Write($"{num} | ");      //1 2 3 4 5
}

