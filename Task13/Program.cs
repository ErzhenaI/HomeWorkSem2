Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse (Console.ReadLine()!);
if (number <= 999 && number > 99)
    Console.WriteLine (number % 10);
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
string numDigit = Convert.ToString (number);
if (number > 999)
    Console.WriteLine($"{numDigit[2]}");