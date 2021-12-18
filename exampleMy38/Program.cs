//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();
int[] array = new int[123];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 1; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine("сумма элементов на нечетной позиции равна " + sum);



