Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(b < a)
if(a > c)
    Console.WriteLine($"max = {a}");
if(a < b)
if(b > c)
    Console.WriteLine($"max = {b}");
if(b < c)
if(c > b)
    Console.WriteLine($"max = {c}");
