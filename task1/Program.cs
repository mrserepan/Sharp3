
﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? str = Console.ReadLine(); 

if (str!.Length > 5 && str!.Length < 5)
{
System.Console.WriteLine("Вы ввели не пятизначное число");
}
else if (str[0] == str[4] && str[1] == str[3])
{
    System.Console.WriteLine("Введённое вами число является палиндромом");
}
else
{
    System.Console.WriteLine("Введённое вами число не является палиндромом");
}    