//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.WriteLine("Введите числа через запятую");
string[] arr = Console.ReadLine().Split();
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (i == arr.Length - 1)
    {
        Console.Write(arr[i]);
    }
    else
    {
        Console.Write(arr[i]);
    }
}
Console.WriteLine("]");