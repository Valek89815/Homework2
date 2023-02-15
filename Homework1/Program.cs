//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
//на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("enter a 3 sign digit");
int a = Convert.ToInt32(Console.ReadLine());

a /= 10;
a %= 10;
Console.WriteLine(a);
