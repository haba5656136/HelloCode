//  2. Даны два числа. Показать большее и меньшее число
int a = 1;
int b = 2;

int max = a;
int min = b;
if (a > max) max = a; min = b;
if (b > max) max = b; min = a;


Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);