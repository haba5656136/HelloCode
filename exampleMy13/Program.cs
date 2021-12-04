//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write( "введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 3;

if (a % b == 0)
{
    Console.WriteLine($"{a} кратно 3");
}
else
{
    Console.WriteLine($"{a} не кратно 3 остаток = {a % b}");
}

