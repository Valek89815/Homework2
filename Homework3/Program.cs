//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("enter a digit: 1,2,3,4,5,6 щк 7");
int d = Convert.ToInt32(Console.ReadLine());

if(d == 6 || d == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

Console.Write("enter a 3 sing digit");
Convert.ToUInt32(Console.ReadLine());