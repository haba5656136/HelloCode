// 8. Показать четные числа от 1 до N

Console.Write("введите число N: ");

 int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1;i<=N;i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" | ");
    }
    
}