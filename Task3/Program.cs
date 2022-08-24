/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("цифра дня недели");
int numberofWeek = Convert.ToInt32(Console.ReadLine());

void CheckThedayOf (int numberofWeek)
{
    if(numberofWeek == 6 || numberofWeek == 7)
{
    Console.WriteLine("(is this day off)yes,have a good day.");
}
else if(numberofWeek < 1 || numberofWeek > 7)
{
    Console.WriteLine("This day isn't day off");
}
else Console.WriteLine("not,Wake up,Time to work man");
}
CheckThedayOf(numberofWeek);