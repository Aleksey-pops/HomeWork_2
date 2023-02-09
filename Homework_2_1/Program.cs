// 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите порядковый номер дня недели: ");
int First = int.Parse(Console.ReadLine()!);

string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",};



if(First == 7)
    Console.WriteLine($"Ура выходной воскресенье! {days[6]}");
else
    Console.WriteLine("Увы не выходной придется поработать.");
// Работает второе условие не коректно    
// Console.WriteLine((First == 7 && First != 7) ? $"Ура выходной воскресенье! {days[6]}" : "Увы не выходной придется поработать.");