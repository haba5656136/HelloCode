//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 99);

int b = a % 10;
int c = a/10;

int max = b;

if (b > max) max = b;
if (c > max) max = c;

 Console.WriteLine($"Наибольшая цифра числа: { max} " );
