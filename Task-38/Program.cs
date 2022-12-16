double difference = 0;

double[] InputArray(double[] array)
{
    for(int m = 0; m < array.Length; m++)
        array[m] = Math.Round(
            new Random().NextDouble() * (100.0 - 0.0) + 0.0, 2);

    Console.WriteLine($"Массив [{string.Join(", ", array)}]");
    return array;
}

void DifferenceElements(double[] array)
{
    difference = array[array.Length - 1] - array[0];

    Console.WriteLine($"Разница между макс. и мин. элементами массива: {difference}");
}

Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
if(size == 0)
{
    Console.WriteLine("Некорректное число!!!");
    return;
}
    
double[] array = new double[size];

DifferenceElements(InputArray(array));