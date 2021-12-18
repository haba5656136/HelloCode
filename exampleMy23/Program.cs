//23. Показать таблицу квадратов чисел от 1 до N 


Console.WriteLine("введите N: ");

int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1;i<=N;i++)
{
    Console.Write(Math.Pow(i, 2));
    Console.Write(" | ");
}
