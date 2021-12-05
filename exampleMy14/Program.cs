// 14. Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("введите число:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x.ToString().Length);

if (x.ToString().Length == 3)Console.WriteLine($"третья цифра числа {x} = {x % 10}");

else if (x.ToString().Length == 4)Console.WriteLine($"третья цифра числа {x} = {x % 100/10}");

else if (x.ToString().Length == 5)Console.WriteLine($"третья цифра числа {x} = {x % 1000/100}");

else if (x.ToString().Length < 3)Console.WriteLine("число меньше трехзначного третьей цыфры нет!");
