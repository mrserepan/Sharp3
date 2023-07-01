
﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3, 6, 8); B (2, 1, -7) -> 15.84
// A (7, -5, 0); B (1, -1, 9) -> 11.53

double result = 0;

System.Console.WriteLine("Введите через пробел координаты первой точки: ");
int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите через пробел координаты второй точки: ");
int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
result = Math.Round(Math.Sqrt(Math.Pow(B[0]-A[0], 2)+Math.Pow(B[1]-A[1], 2)+Math.Pow(B[2]-A[2], 2)), 2);

System.Console.WriteLine("Расстояние между точками =" + (result));