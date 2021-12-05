//17. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("введите первое число:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите второе число:");
double b = Convert.ToDouble(Console.ReadLine());

if((a == b*b)||(b == a*a))
{
     Console.WriteLine("одно число является квадратом другого");
}
else
{   
    Console.WriteLine("одно число не является квадратом другого");
}
