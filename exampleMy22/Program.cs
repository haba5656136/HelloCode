﻿//22. Найти расстояние между точками в пространстве 2D/3D

Console.Clear();

Console.WriteLine("enter position 1 : ");

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter position 2 : ");

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine( "расстояние между точками в 3д пространстве равно: "+S);