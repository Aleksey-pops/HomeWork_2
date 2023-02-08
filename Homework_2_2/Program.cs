
// 2. По двум заданным числам проверять является ли одно квадратом другого
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int First = ReadInt ("Введите первое число: ");
int Second =ReadInt ("Введите второе число: ");
Console.WriteLine((Second == First * First && First != Second * Second) ? "Ура! Первое число является квадратом второго." : "Увы первое число не является квадратом второго.");
Console.WriteLine((First == Second * Second && Second != First * First) ? "Ура! Второе число является квадратом первого.": "Увы Второе число не является квадратом первого.");
