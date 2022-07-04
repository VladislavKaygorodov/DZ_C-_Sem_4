/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int NumSize (int number)
{ 
    int NumA = number;
    int NumB = 0;
    while (NumA>0)
    {
    NumB = NumB + NumA % 10;
    NumA /= 10;
    }
    return NumB;
}

Console.WriteLine("Введите значение сумму составляющих чисел которого нужно узнать: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum = NumSize(num);

Console.WriteLine($"Суммой чисел составляющих значение {num} является {SumNum}");