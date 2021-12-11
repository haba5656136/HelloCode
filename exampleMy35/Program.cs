//35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
int b = new Random().Next(1, 20);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == b)
    {
        Console.WriteLine($"{b} присутствует в заданном массиве");
        break;
    }
    else
    {
        Console.WriteLine($"{b} нет в заданном массиве");
    }
}
