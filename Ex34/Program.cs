// Задать массив, заполненный случайными положительными трёхзначными
// числами. Посчитать количество четных чисел в массиве.

Console.Clear();

Console.Write("Введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, 100, 999);

Console.WriteLine($"Введенный массив: [{string.Join(",", array)}]");
Console.WriteLine($"Количество четных элементов: {evenCount(array)}");

int[] FillArray(int sizeArr, int min, int max)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArr];
    for (int i = 0; i < resultArray.Length; i++)
        resultArray[i] = random.Next(min, max + 1);
    return resultArray;
}

int evenCount(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            counter++;
    return counter;
}