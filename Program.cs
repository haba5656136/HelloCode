 //1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("введите первое число:");

double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите второе число:");

double b = Convert.ToDouble(Console.ReadLine());

if(a == b*b)
{
     Console.WriteLine($"{a} является квадратом {b}");
}
else
{   
    Console.WriteLine($"{a} не является квадратом {b}");
}
