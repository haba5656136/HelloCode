//52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int m = 10;
int n = 10;

double[,] array = new double[m, n];

void FillArray(double[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[j, i] = new Random().Next(0,10);
        }
    }
}

void Coube(double[,] coube)
{
    for (int i = 0; i < coube.GetLength(0); i++)
    {
        for (int j = 0; j < coube.GetLength(1); j++)
        {
            if (0 == j % 2 & 0 == i % 2) 
            {
                coube[j,i] = coube[j,i] * coube[j,i];
            }

          Console.Write(coube[j,i] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Coube(array);