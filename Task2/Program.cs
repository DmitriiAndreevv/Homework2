/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Clear();
Console.WriteLine("write number");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(anyNumber);

if(number.Length > 2)
{
    Console.WriteLine("The third number = " + number[2]);
}
else
{
    Console.WriteLine("the third number is not found");
}