// 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите порядковый номер дня недели: ");
int First = int.Parse(Console.ReadLine()!);

string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",};



// Console.WriteLine((First == days[6], First != days[6]) ? "Ура! Первое число является квадратом второго." : "Увы первое число не является квадратом второго.");
// Console.WriteLine($"Четные числа." + {days[First]}");
Console.WriteLine($"День недели:  {days[First -1]}");
Console.WriteLine($"День недели:  {days[6]}");

