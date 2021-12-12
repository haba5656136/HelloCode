//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int countOnEvent = 0;
int countOffEvent = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        countOnEvent = countOnEvent + 1;
    }
    else
    {
        countOffEvent = countOffEvent + 1;
    }
}
Console.WriteLine(countOnEvent+ " количество четных чисел");
Console.WriteLine(countOffEvent+ " количество нечетных чисел");

