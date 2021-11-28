Console.Clear();
Console.WriteLine(" Написать программу вычисления значения функции y = f(a) где f(a)=x*x+1");

static double F(double x)
    {
         double result = (x*x+1);
         return result;
    }
    Console.WriteLine("введите значение x: ");
  
  double x = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine($"y = {x}*{x}+1 = {F(x)}");
