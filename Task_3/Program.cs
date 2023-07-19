// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int arrLenght = 5;

double[] arr = new double[arrLenght];

void GetArray() // Реализация функции наполнения массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(((new Random().Next(100, 10000)) * 0.01), 2);
        Console.Write(arr[i] + " ");
    }
}

GetArray(); // Вызов функции наполнения массива

double DiffMaxMin() // Реализация функции определения разницы максимального и минимального чисел массива
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return Math.Round((max - min), 2);
}

double diff = DiffMaxMin(); // Вызов функции определения разницы максимального и минимального чисел массива

Console.WriteLine();
Console.WriteLine("Difference between max and min number is: " + diff);