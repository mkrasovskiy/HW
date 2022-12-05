Console.Clear();
Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 99)
{
    Console.WriteLine($"Третьей цифры числа {n} нет");
    return;
}
while (n > 999)
{
    n = n / 10;
}
n = n % 10;
Console.WriteLine(n);