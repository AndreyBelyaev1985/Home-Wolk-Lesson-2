//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
Random rnd = new Random();
int Number = rnd.Next(100,1000);
Console.WriteLine($"Число {Number} После удаления получаем число {Number / 100}{Number % 10}");
