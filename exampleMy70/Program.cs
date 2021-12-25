// 70. Найти сумму цифр числа

int SumNumber(int num)
{
    if (num>0) return num%10+SumNumber(num/10); 
    return 0;
}
Console.WriteLine(SumNumber(0120));
