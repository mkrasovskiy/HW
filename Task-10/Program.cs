Console.Clear();

Console.Write("Введи трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = (n / 10) % 10;
Console.WriteLine($"Второе число {n1}");
