﻿//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int [] array = new int[8];
for (int i = 1; i < 8; i++)
{
    array[i] = new Random().Next(0,2);
    Console.WriteLine(array[i] + " ");
}