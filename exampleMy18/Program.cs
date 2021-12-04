// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] x = { true, false };
bool[] y = { true, false };
int count = 0;

for (int i = 0; i < x.Length; i++)
{
    for (int j = 0; j < y.Length; j++)
    {
        if ((!(x[i] || y[j])) == (!x[i] || !y[j])) count++;
        Console.WriteLine($"{(!(x[i] || y[j])) == (!x[i] || !y[j])}");
    }

}
if (count == 4) Console.WriteLine("Утверждение  ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно!");
else Console.WriteLine("Утверждение  ¬(X ⋁ Y) = ¬X ⋀ ¬Y ложно!");
