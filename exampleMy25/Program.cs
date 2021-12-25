//25. Найти сумму чисел от 1 до А

//Console.WriteLine("введите число А: ");
//int A = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= A; i++)
//{
   /// sum += i;

//}
//Console.WriteLine("сумма чисел от 1 до " + A +" = " + sum);



Console.Write("Введи A: ");
double A = Convert.ToDouble(Console.ReadLine());
double sum = A * (A + 1) / 2;
Console.Write("Сумма равна: ");
Console.WriteLine(sum);
