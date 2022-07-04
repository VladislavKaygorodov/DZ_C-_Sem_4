/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16;*/

Console.WriteLine("Введите возводимое в степень число: ");
int NumStep = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень возводимого числа: ");
int Step = Convert.ToInt32(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(NumStep, Step));

Console.WriteLine($"При возведении числа {NumStep} в степень {Step} получается {result}");