//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

string numberWeekDay = Console.ReadLine();

if(numberWeekDay.ToLower() == "1")
{
    Console.WriteLine("Понедельник");
}
if(numberWeekDay.ToLower() == "2")
{
    Console.WriteLine("Вторник");
}
if(numberWeekDay.ToLower() == "3")
{
    Console.WriteLine("Среда");
}
if(numberWeekDay.ToLower() == "4")
{
    Console.WriteLine("Четверг");
}
if(numberWeekDay.ToLower() == "5")
{
    Console.WriteLine("Пятница");
}
if(numberWeekDay.ToLower() == "6")
{
    Console.WriteLine("Суббота");
}
if(numberWeekDay.ToLower() == "7")
{
    Console.WriteLine("Воскресенье");
}
if(numberWeekDay.ToLower() == "6"|| numberWeekDay.ToLower() == "7")
{
    Console.WriteLine("выходной день!!!");
}