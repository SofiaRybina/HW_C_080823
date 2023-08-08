// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение массива:");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение массива:");
int maxNum = Convert.ToInt32(Console.ReadLine());

if (minNum <= maxNum)
{
    int[] array = CreateArrayRndInt(sizeArray, minNum, maxNum); //100 - 999
    Console.WriteLine();

    if (minNum >= 100 && maxNum <= 999)
    {
        PrintArray(array);
        Console.Write($"-> {EvenNum(array)}");
    }
    else
    {
        Console.WriteLine("Error: Числа должны быть положительными и трёхзначными!");
    }
}
else
{
    Console.WriteLine("Error: Минимальное значение должно быть меньше Максимального!");
}