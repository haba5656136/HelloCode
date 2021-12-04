// факториал

double Faktorial(int n)
{
    if (n == 1) return 1;
    else return n * Faktorial(n - 1);
}
for (int i = 0; i < 2; i++)
{
  Console.WriteLine($"{i}! = {Faktorial(i)}");  
}
