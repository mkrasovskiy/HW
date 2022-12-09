Console.Clear();
Console.Write("Введите пятизначное число: ");
string n = Console.ReadLine();
if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine("Палиндром");
else 
    Console.WriteLine("Не палиндром");