// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void Array(int[] numbers)
{
    int len = numbers.Length;
    int sum = 0;
    Console.Write("[ ");

    for(int i = 0; i < len; i++)
    {
        numbers[i] = new Random().Next(-100,100);
        Console.Write($"{numbers[i]} ");
        int SomeNumber = i % 2;
            if(SomeNumber != 0) sum = sum + numbers[i]; 
    }
    Console.Write($" ] -> {sum}");
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());


int[] massive = new int[length];
Array(massive);
