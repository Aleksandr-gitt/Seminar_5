// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Array(double[] numbers)
{
int len = numbers.Length;

for(int i = 0; i < len; i++)
{
    numbers[i] = new Random().Next() + new Random().NextDouble();  
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

double min = numbers[0];
double max = numbers[0]; 

for(int i = 0; i < len; i++)
{
    if(max < numbers[i]) max = numbers[i];
    if(min > numbers[i]) min = numbers[i];
}

Console.WriteLine($"MaxNumber = {max}");
Console.WriteLine($"MinNumber = {min}");

double result = max - min;
Console.WriteLine($"Разница - {result}");
}

Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Array(new double[length]);
