// 69. Найти сумму элементов от M до N, N и M заданы

//int SumRec(int n)
//{
// if (n ==0) return 0;
// else return n + SumRec(n - 1);
//}
//Console.WriteLine(SumRec(10)); сумма от 1 до n с лекции

int SumRec(int m, int n)
{
    if (m < n)return m + SumRec(m + 1, n);
    if (m > n) return m + SumRec(m - 1, n);
    else return m;
}
Console.WriteLine(SumRec(5, 5));
