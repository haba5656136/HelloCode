//50. В двумерном массиве n×k заменить четные элементы на противоположные


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

void ConvertToEven(double[,] even)
{
    for (int i = 0; i < even.GetLength(0); i++)
    {
        for (int j = 0; j < even.GetLength(1); j++)
        {
            if (0 == even[j,i] % 2) 
            {
                even[j,i] = even[j,i] * -1;
            }

            Console.Write(even[j, i] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
ConvertToEven(array);