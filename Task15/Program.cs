Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int n = int.Parse (Console.ReadLine()!);
while (n < 1 || n > 7)
{
    Console.WriteLine ("Вы ошиблись!\nВведите номер дня недели: ");
    n = int.Parse (Console.ReadLine()!);
}
if (n == 6 || n == 7)
    Console.WriteLine ("Ура, выходной!");
else
    Console.WriteLine ("Этот день не является выходным");