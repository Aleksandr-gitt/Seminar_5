// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Array(int[] numbers)
{
    int len = numbers.Length;
    int count = 0;
    Console.Write("[ ");

    for(int i = 0; i < len; i++)
    {
        numbers[i] = new Random().Next(100,1000);
        Console.Write($"{numbers[i]} ");
        int SomeNumber = numbers[i] % 2;
            if(SomeNumber == 0) count++; 
    }
    Console.Write($" ] -> {count}");
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());


int[] massive = new int[length];
Array(massive);

