// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита


void Alphavite(string word, string alpha, int length)
{
    if (length < 1)
    {
        Console.WriteLine(word);
        return;
    }
    foreach (var character in alpha)
    {
        Alphavite(word + character, alpha, length - 1);
    }
}
Console.Write("ввести длину слова: n- ");
int number = Convert.ToInt32(Console.ReadLine());
string alphaNew = "аисв";
Alphavite("", alphaNew, number);





// char[] array = { 'а','и','c','в' };
// int count = array.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//            for (int m = 0; i < count; m++)
//            {
//               Console.WriteLine($"{n++,-5}{array[i]}{array[j]}{array[k]}{array[m]}"); 
//            } 
//         }
//     }
// }