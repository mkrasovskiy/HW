int sum = 0;

int[] InputArray(int[] array)
{
    for(int m = 0; m < array.Length; m++)
        array[m] = new Random().Next(0,100);

    Console.WriteLine($"Массив [{string.Join(", ", array)}]");
    return array;
}

void SumElements(int[] array)
{
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];

    Console.WriteLine($"Сумма нечетных элементов массива: {sum}");
}

Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

SumElements(InputArray(array));