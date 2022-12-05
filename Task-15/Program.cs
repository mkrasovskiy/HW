Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dn = Convert.ToInt32(Console.ReadLine());
if (dn == 6 || dn == 7)
    Console.WriteLine("Выходной день");
else if (dn < 1 || dn > 7)
    Console.WriteLine("Это не день недели");
else 
    Console.WriteLine("Не выходной день");

