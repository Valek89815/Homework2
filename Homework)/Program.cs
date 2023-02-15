//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("enter a digit");
string str = Console.ReadLine();
char[] arr = str.ToCharArray();
if(arr.Length > 2)
{
    Console.WriteLine(arr[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}