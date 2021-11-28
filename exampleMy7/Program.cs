// 7.Показать числа от -N до N


Console.WriteLine("введите N: ");

int N = int.Parse(Console.ReadLine());

for(int i = -N;i<=N;i++)
{
    Console.Write(i);
    Console.Write(" ; ");
}
