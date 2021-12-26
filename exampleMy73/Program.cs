// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента 
//последовательности задаются пользователем
int N = 10;
int Fibonacci(int first,int second,int n)
{
    if(n == 1) return first;
    if(n == 2) return second;
    return Fibonacci(first,second,n-1) + Fibonacci(first,second,n-2);
}
for (int i = 1; i <= N; i++)
{
   Console.Write($"{Fibonacci(10,28,i)}, "); 
}
    