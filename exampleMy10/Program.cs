//10. Показать вторую цифру трёхзначного числа
Console.WriteLine("введите трехзначное число: " );
 
 int numberA = Convert.ToInt32(Console.ReadLine());

 int numberB = numberA % 100;
 
 Console.WriteLine($"последняя цифра в числе:{numberB/10} " );


