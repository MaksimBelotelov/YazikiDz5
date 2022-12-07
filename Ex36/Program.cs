// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.Write("Введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, -10, 10);

Console.WriteLine($"Введенный массив: [{string.Join(",", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {evenPosSum(array)}");

int[] FillArray(int sizeArr, int min, int max)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArr];
    for (int i = 0; i < resultArray.Length; i++)
        resultArray[i] = random.Next(min, max + 1);
    return resultArray;
}

int evenPosSum(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
        result += arr[i];
    return result;
}
