Console.Clear();
Console.WriteLine(" Написать программу вычисления значения функции y = f(a) где f(a)=x*x+1");

void NameFunction(int namberF);
{
 namberF = namberF * namberF + 1;
 return namberF;
}
Console.Write("введите значение а: ");

int namberA = int.Parse(Console.ReadLine());
int namberY = NameFunction(namberA);

Console.WriteLine($"y = {namberA} * {namberA} + 1 = {namberY}");