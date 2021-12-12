//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();
int[] array = new int[123];
int col = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for (int i = 10; i < 100; i++)
{
    col += 1;
}
Console.WriteLine("количество элементов равно " + col);



