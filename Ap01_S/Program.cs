for (; ; )
{
    Console.WriteLine("1. 成績計算");
    Console.WriteLine("2. 成績計算");
    Console.WriteLine("3. 外幣兌換")
    Console.WriteLine("0. 結束");
    Console.WriteLine("請輸入選項：");
    string s = Console.ReadLine();
    int opt = int.Parse(s);
    switch (opt)
    { 
        case 0:
            return;
        case 1:
            CalcScore();
            break;
        case 2:
            CalcTax();
            break;
        case 3:
            Exchange();
            break;
        default:
            Console.WriteLine("選項錯誤");
            break;
    }
}

void CalScore()
{
    int score;
    string s;

    Console.Write("成績:");
    s = Console.ReadLine();
    score = int.Parse(s);

    if (score < 60)
        Console.WriteLine("C-class");
    else if (score < 80)
        Console.WriteLine("B-class");
    else
        Console.WriteLine("A-class");
}