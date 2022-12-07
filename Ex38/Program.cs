// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементом массива.

Console.Clear();

double[] array = FillArray();

Console.WriteLine($"Введенный массив: [{string.Join("|", array)}]");
Console.WriteLine($"Разность между максимальным и минимальным: {divMaxMin(array)}");

double[] FillArray()
{
    Console.Write("Введите число элементов в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] resultArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите значение элемента {i}: ");
        resultArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return resultArray;
}

double divMaxMin(double[] arr)
{
    double min = arr[0], max = arr[0], result;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Максимальный элемент: {max}");
    Console.WriteLine($"Максимальный элемент: {min}");
    result = Math.Round(max - min, 3);

    return result;
}
