//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Console.WriteLine("введите координату x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());

if(x>0 & y>0) Console.WriteLine("точка находится в 1 ой четверти");
if(x<0 & y>0) Console.WriteLine("точка находится во 2 ой четверти");
if(x<0 & y<0) Console.WriteLine("точка находится в 3 ой четверти");
if(x>0 & y<0) Console.WriteLine("точка находится в 4 ой четверти");
if(x == 0 || y == 0) Console.WriteLine(" один из координат равен 0, не соответствует условию задачи!");
