/*Напишите программу, которая на вход принмает 3 трехзначных числа и находит среднее арифметическое, далее проверяет больше ли последняя цифра среднего арифметического, чем первая цифра минимума вводимых чисел.

111, 222, 333 - да
532, 164, 114 - нет
551, 235, 639 - цифры равны*/

Console.Clear();
Console.WriteLine("введите число");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("введите число");
int b =int.Parse(Console.ReadLine());
Console.WriteLine("введите число");
int c =int.Parse(Console.ReadLine());

int Max(int arg1, int arg2, int arg3) 
{
    int min = arg1;
    if(arg2 > min) min = arg2;
    if(arg3 > min) min = arg3;
    return min;
}
int min = Math.Min(Math.Min(a, b), c);
int avg = (a + b + c)/3;
avg = (avg)%10;
min = (min)%10;

Console.WriteLine(min);
Console.WriteLine(avg);

if(avg > min)
{
    Console.WriteLine("Yes");
}
if(avg < min)
{
    Console.WriteLine("No");
}
else if (avg == min)
{
    Console.WriteLine("цифры равны");
}