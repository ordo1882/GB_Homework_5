// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int arrLenght = 6;

int[] arr = new int[arrLenght];

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-99, 100);
    Console.Write(arr[i] + " ");

    if(i % 2 != 0)
    {
        sum += arr[i];
    }
}

Console.WriteLine();
Console.WriteLine("Odd indexes sum is " + sum);