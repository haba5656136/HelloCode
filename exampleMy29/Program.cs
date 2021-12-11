//29. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;

Console.WriteLine("N = " + N);

for (int i = 1; i <= N; i++)
{
    a = i*a;
    Console.WriteLine($"{i}*{a}");
}
Console.WriteLine("произведение всех чисел равно = " + a);
