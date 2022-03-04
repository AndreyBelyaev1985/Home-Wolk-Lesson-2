// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число => ");
string A = Console.ReadLine();
int[]arr = new int[A.Length];
for (int i=0; i < A.Length; i++)
{
    arr[i] = Convert.ToInt32(A.Substring(i,1));

}
if (arr.Length < 3) Console.WriteLine($"Третья цифра отсутствует");
else Console.WriteLine($"Третья цифра заданного числа => {arr[2]}");