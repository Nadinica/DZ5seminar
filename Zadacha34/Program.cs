// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] CreateAndFill(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = Random.Shared.Next(100, 999);
    }
    return array;
}

void Print(int[] numbers)
{
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Напишите число N ");
int len = Convert.ToInt32(Console.ReadLine());
int[] a = CreateAndFill(len);
Print(a);

int Check(int[] numbers)
{
    int count = 0;
    int size = numbers.Length;
    int index = 0;
    while (index < size)
    {
        if (numbers[index] % 2 == 0) count++;
        index++;
    }
    return count;
}
int pos = Check(a);
Console.Write("четных чисел: ");
Console.WriteLine(pos);