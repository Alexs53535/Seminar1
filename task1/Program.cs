﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if ((n1 > n2) & (n1 > n3))
    Console.WriteLine($"{n1}, {n2}, {n3} -> {n1} ");
else if (n2 > n3)
    Console.WriteLine($"{n1}, {n2}, {n3} -> {n2} ");
else 
    Console.WriteLine($"{n1}, {n2}, {n3} -> {n3} ");