// 60. Составить частотный словарь элементов двумерного массива

// int m = 10;
// int n = 10;


// double[,] array = new double[m, n];

// void FillArray(double[,] fill)
// {
//     for (int i = 0; i < fill.GetLength(0); i++)
//     {
//         for (int j = 0; j < fill.GetLength(1); j++)
//         {
//             fill[j, i] = new Random().Next(0,10);

//         }
//     }
// }

// var array = Enumerable.Range(1,100).Select(e=>new Random().Next(1,10))
// .GroupBy(e=>e);
// foreach (var item in array)
// {
//     Console.WriteLine($"{item.Key}  {item.Count()}");
// }
int[] array = { 1,1, 1,1, 1,1, 41, 15, 6,1, 17, 1,8, 19,6,6,6,6,6 };
int min = array.Min();
int max = array.Max();
Console.WriteLine(max);
int[] arrayNew = new int[max + 1];
for (int i = 0; i < array.Length; i++)
{
    arrayNew[array[i]]++;

}
for (int i = 0; i < arrayNew.Length; i++)
{
    if (arrayNew[i] != 0)
    {
        Console.WriteLine($"{i}  {arrayNew[i]}");
    }
}

