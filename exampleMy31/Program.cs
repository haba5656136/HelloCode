//31. Задать массив из 8 элементов и вывести их на экран 

int [] array = new int[8];
for (int i = 1; i < 8; i++)
{
    array[i] = new Random().Next(1,10);
    Console.WriteLine(array[i] + " ");
}