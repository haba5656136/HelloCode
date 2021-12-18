//35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
int b = new Random().Next(1,20);
bool result = false;


for (int i = 0; i < array.Length; i++)
{
    if (b == array[i])
    {
        result = true;
        break;
    }
}
if (result) Console.WriteLine($"{b} в массиве");
else Console.WriteLine($"{b} нет в массиве");
