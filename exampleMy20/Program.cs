//20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("введите номер четверти: ");
int xy = Convert.ToInt32(Console.ReadLine());

if (xy == 1) Console.WriteLine("диапозон значений в 1 четверти x(0,100); y(0,100)");
else if (xy == 2) Console.WriteLine("диапозон значений во 2 четверти x(-100,0); y(0,100)");
else if (xy == 3) Console.WriteLine("диапозон значений в 3 четверти x(-100,0); y(-100,0)");
else if (xy == 4) Console.WriteLine("диапозон значений в 4 четверти x(0,100);y (-100,0)");
else Console.WriteLine("введите значение от 1 до 4");