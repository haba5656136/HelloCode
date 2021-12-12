//39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[]array = {1,2,3,4,5,6,7,8,9,10};

int[] res = new int[array.Length/2];
int first = 0;
int last = array.Length-1; 

while (first < last)
{
    int i =0;
    res[i] = array[first]*array[last];
    first++;
    last--;
    Console.Write(" "+res[i] );
    i++;
}