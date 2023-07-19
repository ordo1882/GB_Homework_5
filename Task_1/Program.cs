// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int arrLenght = 12;

int[] arr = new int[arrLenght];

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write(arr[i] + " ");

    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Even numbers quantity is " + count);