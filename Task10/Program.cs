Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse (Console.ReadLine()!);
Console.WriteLine((n % 100 - n % 10) / 10);