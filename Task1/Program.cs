/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.WriteLine("write number");
int secondNum =int.Parse(Console.ReadLine());
Console.WriteLine($"secondNum = {(secondNum/10)%10}");