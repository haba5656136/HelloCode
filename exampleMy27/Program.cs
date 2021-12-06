//27. Определить количество цифр в числе

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (x>0)
{
   x=x/10;
   count++;
}

Console.WriteLine($"{count} цифр в числе");