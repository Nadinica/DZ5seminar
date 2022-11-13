// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void CreateAndFill(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Напишите колличество элементов массива ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
CreateAndFill(array);
PrintArray(array);

int Summa(int[] collection)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int S = Summa(array);
Console.Write("Сумма чисел на не четной позиции равна ");
Console.WriteLine(S);

