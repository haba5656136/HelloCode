﻿//24. Найти кубы чисел от 1 до N
Console.WriteLine("введите N: ");

int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1;i<=N;i++)
{
    Console.WriteLine(i + " в кубе = " + Math.Pow(i, 3));
}