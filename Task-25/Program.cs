  Console.Write("Введите первое число: ");
  int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int m = Convert.ToInt32(Console.ReadLine());
  int res = 1;
  for (int i = 0; i < m; i++) 
  {
   res *= n;
  }
  Console.WriteLine($"{res}");