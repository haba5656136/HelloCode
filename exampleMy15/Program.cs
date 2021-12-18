//15. Дано число. Проверить кратно ли оно 7 и 23

Console.Write("введите число : ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 7 == 0 && x % 23 == 0)
{
    Console.WriteLine("кратно 7 и 23");
}
else
{
    Console.WriteLine("не кратно 7 и 23");
}