// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void CreateAndFill(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-12, 15);
        index++;
    }
}
void PrintArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}
double[] array = new double[10];
CreateAndFill(array);
PrintArray(array);

double Max(double[] nums)
{
    double max = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {

        if (nums[i] > max) max = nums[i];
    }
    return max;
}
Console.Write("Максимальное число ");
double m = Max(array);
Console.WriteLine(m);

double Min(double[] nums)
{
    double min = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {

        if (nums[i] < min) min = nums[i];
    }
    return min;
}
Console.Write("Минимальное число ");
double n = Min(array);
Console.WriteLine(n);
Console.Write("Разница между максимальным и минимальным элементом масива: ");
Console.WriteLine(m - n);