//猜數字遊戲

Random rnd = new Random();
int answer = rnd.Next(1, 100);
int guess, min = 1, max = 99;
string s;

do
{
    Console.Write($"請猜一個{min}-{max}的數字:");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if (guess == -1)
    {
        Console.WriteLine($"答案是{answer}");
        break;
    }
    if (guess < min || guess > max)
    {
        Console.WriteLine($"請輸入{min} - {max}的數字");
        continue;
    }

    if (guess > answer)
        max = guess - 1;
    else if (guess < answer)
        min = guess + 1;
    else
        Console.WriteLine("猜對了");
} while (answer != guess);
