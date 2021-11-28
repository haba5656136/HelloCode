 //1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("введите число numberA: ");
 
 double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите число numberB: ");
 
 double numberB = Convert.ToDouble(Console.ReadLine());

 if(numberA == numberB*numberB)
 {
     Console.WriteLine(numberA+(" является квадратом ")+numberB);
 }
 else
 {
     Console.WriteLine(numberA+(" не является квадратом ")+numberB);
 }
 