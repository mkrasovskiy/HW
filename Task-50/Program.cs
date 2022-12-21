Console.Clear();
Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] size = new int [10, 10];
ArrayRandomNumbers(size);
PrintArray(size);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }   
        Console.WriteLine(" "); 
    }
}

if (n > size.GetLength(0) || m > size.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца = {size[n-1, m-1]}");
}