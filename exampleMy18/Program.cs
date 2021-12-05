// 18.Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] all = {true, false};

bool result = true;

for(int i = 0; i <all.Length; i++)
{
    for(int j = 0; j <all.Length; j++)
    {
        if( !(all[i] || all[j]) == (!all[i] && all[j]))
        {
            Console.WriteLine($"Для набора x = {all[i]}, y = {all[j]} выражение истинно");
        }
        else
        {
            Console.WriteLine($"Для набора x = {all[i]}, y = {all[j]} выражение ложно");
            result = false;
            break;
        }

    }
}

if(result)
{
    Console.WriteLine($"Доказано что утверждение истинно");
} else
{
    Console.WriteLine($"Доказано что утверждение ложно");
}