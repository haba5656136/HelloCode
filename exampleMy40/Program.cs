//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();
int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}
int maxNumber = array.Max();
int minNumber = array.Min();

Console.WriteLine($"{maxNumber} - {minNumber} = {maxNumber-minNumber}");
