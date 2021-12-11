//34. Написать программу замену элементов массива на противоположные

int[] array = { 1, 2, 3, 4, 5 };

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i]);
    Console.Write(",");
}
