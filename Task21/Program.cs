﻿// Задача 21 Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine($"Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double distans = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine($"Расстояние между точками равно {distans}");