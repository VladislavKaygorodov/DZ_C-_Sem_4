/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите размер создаваемого массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int [] Array = new int [arraySize];

void CreatArray ( int [] array)
{
    int length = array.Length;
    int index = 0;
    for (;index < 1; index++)
    {
        Console.WriteLine("Введите значение первого элемента массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array [index] = num;
    }
    for (index = 1; index < length; index++)
    {
        Console.WriteLine("Введите значение следующего элемента массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array [index] = num;
    }
}

CreatArray(Array);

Console.Write($"Состав созданного массива: [{String.Join(";", Array)}]");