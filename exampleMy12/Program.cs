//12. Удалить вторую цифру трёхзначного числа
Console.Write("введите трехзначное число: ");

int a= Convert.ToInt32(Console.ReadLine());

int number3 = a % 10;
int number1 = a / 100;

Console.WriteLine($"{number1}{number3}");