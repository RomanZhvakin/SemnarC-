﻿Console.Write("Напишите первое число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Напишите второе число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i ++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();