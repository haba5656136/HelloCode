//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

int m = 10;
int n = 10;

double[,] array = new double[m, n];

void FillArray(double[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[j, i] = i + j;
        }
    }
}
void PrintArray(double[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[j, i] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);