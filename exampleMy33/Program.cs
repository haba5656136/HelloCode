//33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sumPositive += array[i];
    else sumNegative += array[i];
}
Console.WriteLine("сумма положительных элементов  "+sumPositive);
Console.WriteLine("сумма отрицательных элементов "+sumNegative);