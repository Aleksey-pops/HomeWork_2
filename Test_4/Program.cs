using System;
// Растояние между точками 2D
// double ReadDouble(string message)
// {
//     Console.Write(message);
//     return double.Parse(Console.ReadLine()!);
// }
// double First = ReadDouble ($"Введите Координаты первой точки число для нахождения растояния на плоскости на оси Х, X =   ");
// double Second = ReadDouble ($"Введите Координаты первой точки число для нахождения растояния на плоскости на оси Y, Y =  ");
// double First_1 = ReadDouble ($"Введите Координаты второй точки число для нахождения растояния на плоскости на оси Х, X2 = ");
// double Second_1 =ReadDouble ($"Введите Координаты второй точки числодля нахождения растояния на плоскости на оси Y, Y2 = ");
// double Long = Math.Sqrt((First_1 - First)*(First_1 - First) + (Second_1 - Second)*(Second_1 - Second));

// Console.WriteLine($"Растояние между точками 2D: {Long}");

// Растояние между точками 3D

double ReadDouble(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}
double First = ReadDouble ($"Введите Координаты первой точки число для нахождения растояния в 3D на оси Х, X =  ");
double Second = ReadDouble ($"Введите Координаты первой точки числодля нахождения растояния в 3D на оси Y, Y =  ");
double Three = ReadDouble ($"Введите Координаты первой точки число для нахождения растояния в 3D на оси Z, Z =  ");
double First_1 =ReadDouble ($"Введите Координаты второй точки число для нахождения растояния в 3D на оси Х, X2 =  ");
double Second_1 = ReadDouble ($"Введите Координаты второй точки число для нахождения растояния в 3D на оси Y, Y2 =  ");
double Three_1 =ReadDouble ($"Введите Координаты второй точки число для нахождения растояния в 3D на оси Z, Z2 =  ");
double Long = Math.Sqrt((First_1 - First) * (First_1 - First) + (Second_1 - Second)*(Second_1 - Second) + (Three_1 - Three) * (Three_1 - Three));

Console.WriteLine($"Растояние между точками 3D: {Long}");
