//4. Найти максимальное из трех чисел

int a = new Random().Next(1, 10);

Console.WriteLine("введите переменную b:");

int b = int.Parse(Console.ReadLine());

int c = 5;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max = ");
Console.WriteLine(max);
