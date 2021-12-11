//30. Показать кубы чисел, заканчивающихся на четную цифру


Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 10 == 1 )
{
     Console.WriteLine("последнее число нечетное");
}
else 
{
    Console.WriteLine("последнее цифра числа четная, куб числа = " + Math.Pow(number,3));
}