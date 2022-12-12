Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0) 
{
    int a = n % 10;
    n /= 10;
    sum += a;
}       
Console.WriteLine(sum);