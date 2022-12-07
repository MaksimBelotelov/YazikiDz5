/* Задать одномерный массив, заполненный случайными числамии. Из входного массива 
сформировать массив с четными и массив с нечетными значениями элементов входного массива.
Найти среднее арифметическое из полученных значений элементов массивов и вывести результат
сравнения средних арифметических*/

Console.Clear();

Console.Write("Введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, 0, 10);
int[] evArr = EvenOddSeparate(array).Item1;
int[] oddArr = EvenOddSeparate(array).Item2;

Console.WriteLine($"Введенный массив: [{string.Join(",", array)}]");
Console.WriteLine($"Массив четных: [{string.Join(",", evArr)}]");
Console.WriteLine($"Массив нечетных: [{string.Join(",", oddArr)}]");

if (AvgArr(evArr) > AvgArr(oddArr))
    Console.WriteLine("Среднее массива четных больше, чем среднее массива нечетных.");
else if (AvgArr(evArr) < AvgArr(oddArr))
    Console.WriteLine("Среднее массива нечетных больше, чем среднее массива четных.");
else
    Console.WriteLine("Средние массивов равны.");

int[] FillArray(int sizeArr, int min, int max)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArr];
    for (int i = 0; i < resultArray.Length; i++)
        resultArray[i] = random.Next(min, max + 1);
    return resultArray;
}

(int[], int[]) EvenOddSeparate(int[] arr)
{
    int countEven = 0, countOdd = 0;
    int j = 0, k = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) countEven++;
        else countOdd++;

    int[] evenArr = new int[countEven];
    int[] oddArr = new int[countOdd];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenArr[j] = arr[i];
            j++;
        }
        else
        {
            oddArr[k] = arr[i];
            k++;
        }
    }
    return (evenArr, oddArr);
}

int AvgArr(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
        result += arr[i];
    result /= arr.Length;

    return result;
}