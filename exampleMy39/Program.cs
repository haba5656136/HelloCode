//39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}

Console.WriteLine($"произведение первого и последнего числа массива : {array[0]} * {array[array.Length-1]} = {array[0]*array[array.Length-1]}");
длину-1
//доделать цикл произведений
