Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = (sum + matrix[i, j]);
    }
    sum = Math.Round(sum / size[0], 1);
    
    Console.Write(sum + "; ");
}

Console.WriteLine();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
}
