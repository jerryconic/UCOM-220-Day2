Random rnd = new Random();
int ans = rnd.Next(0, 100);
int guess, min=1, max=99;
string s;

do
{
    Console.Write($"請猜一個{min}-{max}的數字：");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if (guess == -1)
    {
        Console.WriteLine($"答案是{ans}");
        break;
    }

    if (guess < min || guess > max)
    {
        Console.Write($"請輸入一個{min}-{max}的數字：");
        continue;
    }

    if (guess > ans)
        max = guess - 1;
    else if (guess < ans)
        min = guess + 1;
    else
        Console.WriteLine("猜對了!!!!");
}
while (ans != guess);
