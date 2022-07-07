//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int j = 1;
while (Math.Abs(num) - j >= 0)
{
    Console.Write($"{j * j * j},");
    j++;
}
System.Console.Write("\b \b");