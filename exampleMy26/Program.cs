//26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите в какую степень надо возвести: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = A;

for (int i = 1; i < B; i++)
{
    A *= A;// или A*A
}
Console.WriteLine($"{C} в степени {B} = {A}");