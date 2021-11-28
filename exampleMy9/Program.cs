// 9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("введите трехзначное число: " );
 
 int numberA = Convert.ToInt32(Console.ReadLine());

 int numberB = numberA % 10;
 
 Console.WriteLine($"последняя цифра в числе:{numberB} " );
