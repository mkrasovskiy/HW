Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
    if ((x % 2) == 0)
        Console.WriteLine($"{x} четное число");
    else 
         Console.WriteLine($"{x} нечетное число");
