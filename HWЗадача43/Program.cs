﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение k1: "); 
double k1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите значение b1: "); 
double b1 = Convert.ToInt64(Console.ReadLine()); 
Console.WriteLine("Введите значение k2: "); 
double k2 = Convert.ToInt64(Console.ReadLine()); 
Console.WriteLine("Введите значение b2: "); 
double b2 = Convert.ToInt64(Console.ReadLine()); 

void Znachenia (double k1, double b1, double k2, double b2) 
 { 
     if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают"); 
     else if (k1 == k2) Console.WriteLine("Линии не пересекаются"); 
     else 
     { 
         double x = (b2 - b1) / (k1 - k2); 
         double y = k1 * x + b1; 
        Console.WriteLine($"Линии пересекаются в точке ({x}, {y})"); 
     } 
 } 
 Znachenia (k1, b1, k2, b2);