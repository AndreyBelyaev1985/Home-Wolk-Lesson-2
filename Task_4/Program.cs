//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);
    if (A > 7) Console.WriteLine($"Неверно указан день недели");
    else
    if (A < 6) Console.WriteLine($"Рабочий день");
    else 
    Console.WriteLine($"Выходной день");