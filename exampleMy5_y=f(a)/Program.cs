
Console.WriteLine(" Написать программу вычисления значения функции y = f(a)");

double f(double x);
{
    double result = x*x+1;
    return result;
}
Console.WriteLine($"x = {result}");