﻿// Напишите программу, которая на вход принимает число и выдаёт, является лт чётным ( делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет 
// 7 -> нет

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.Write("Число является нечётным ");
}
else
{
    Console.Write("Число является чётным ");
}
