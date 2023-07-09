// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7 - ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.Write("1 -> Нет");
        break;
    case 2:
        Console.Write("2 -> Нет");
        break;
    case 3:
        Console.Write("3 -> Нет");
        break;
    case 4:
        System.Console.Write("4 -> Нет");
        break;
    case 5:
        System.Console.Write("5 -> Нет");
        break;
    case 6:
        System.Console.Write("6 -> Да");
        break;
    case 7:
        System.Console.Write("7 -> Да");
        break;
}
if (num > 7 || num < 1)
{
    Console.WriteLine("Такого дня недели нет");
}