﻿string s;
int n, total = 0;

do
{
    Console.Write("n=");
    s = Console.ReadLine();
    n = int.Parse(s);
    total += n;
} while (n != 0);

Console.WriteLine($"Total={total}");