//42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("введите количество вводимых чисел : ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int sum = 0;
Console.Write("введите числа :  ");
for (int i = 0; i < N; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sum = sum + 1;
}
Console.WriteLine("чисел больше ноля : " + sum);