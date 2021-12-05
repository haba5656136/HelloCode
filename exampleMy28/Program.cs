//28. Подсчитать сумму цифр в числе

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number.ToString().Length;
int result = 0;
int mod = 0;

for (int i = 0; i < N; i++)
{
 
  mod = number % 10;
  number = number / 10;
  result = mod + result;   
}
Console.WriteLine($"сумма цифр в числе равна =  {result}");