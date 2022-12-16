int count = 0;

int[] InputArray(int[] array)
{
    for(int m = 0; m < array.Length; m++)
        array[m] = new Random().Next(100,1000);

    Console.WriteLine($"Массив [{string.Join(", ", array)}]");
    return array;
}

void RealiseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;

    Console.WriteLine($"Количество четных чисел: {count}");
}

Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

RealiseArray(InputArray(array));