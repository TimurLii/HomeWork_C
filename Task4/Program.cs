﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine(" Введите число ");
int number = int.Parse(Console.ReadLine()!);
int number1=2;

while (number >= number1)
{
     Console.WriteLine(number1);
     number1=number1+2;
}