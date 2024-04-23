﻿//猜數字遊戲

Random rnd = new Random();
int answer = rnd.Next(1, 100);
int guess;
string s;

do
{
    Console.Write("請猜一個1-99的數字:");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if(guess==-1)
    {
        Console.WriteLine($"答案是{answer}");
        break;
    }
    if(guess < 1 || guess > 99)
    {
        Console.WriteLine("請輸入1-99的數字");
        continue;
    }

    if (guess > answer)
        Console.WriteLine("低一點");
    else if (guess < answer) 
        Console.WriteLine("高一點");
    else
        Console.WriteLine("猜對了");
} while (answer!=guess);
