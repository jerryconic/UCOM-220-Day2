Random rnd = new Random();
int ans = rnd.Next(0, 100);
int guess;
string s;

do
{
    Console.Write("請猜一個1-99的數字");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if (guess == -1)
    {
        Console.WriteLine($"答案是{ans}");
        break;
    }

    if (guess < 0 || guess > 100)
    {
        Console.Write("請輸入一個1-99的數字");
    }
    if (guess > ans)
        Console.WriteLine("低一點");
    else if (guess < ans)
        Console.WriteLine("高一點");
    else
        Console.WriteLine("猜對了!!!!");
}
while (ans != guess);
