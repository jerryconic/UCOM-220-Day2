for (; ; )
{
    Console.WriteLine("1.計算成績");
    Console.WriteLine("2.計算所得稅");
    Console.WriteLine("3.外幣兌換");
    Console.WriteLine("0.結束");
    Console.WriteLine("請輸入選項:");
    string s = Console.ReadLine();
    int opt = int.Parse(s);
    switch(opt)
    {
        case 1:
            CalcScore();
            break;
        case 2:
            CalcTax();
            break;
        case 3:
            Exchange();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("選項錯誤");
            break;

    }
}


void CalcScore()
{
    int score;
    string s;

    Console.Write("成績:");
    s = Console.ReadLine();
    score = int.Parse(s);

    /*
    if (score < 60)
        Console.WriteLine("C-Class");
    else if (score < 80)
        Console.WriteLine("B-Class");
    else
        Console.WriteLine("A-Class");
    */
    Console.WriteLine(score < 60 ? "C-Class" : score < 80 ? "B-Class" : "A-Class");
}
void CalcTax()
{
    string s;
    int income, tax;
    Console.Write("年所得收入:");
    s = Console.ReadLine();
    income = int.Parse(s);

    if (income <= 590000)
        tax = (int)(income * 0.05 + 0.5);
    else if (income <= 1330000)
        tax = (int)(income * 0.12 - 41300 + 0.5);
    else if (income <= 2660000)
        tax = (int)(income * 0.2 - 147700 + 0.5);
    else if (income <= 4980000)
        tax = (int)(income * 0.3 - 413700 + 0.5);
    else
        tax = (int)(income * 0.4 - 911700 + 0.5);

    //Console.WriteLine("年所得收入:{0:#,##0}, 應納所得稅:{1:#,##0}", income, tax);
    Console.WriteLine($"年所得收入:{income:#,##0}, 應納所得稅:{tax:#,##0}");
}

void Exchange()
{
    string s, curr;
    int nt;
    decimal amt;
    Console.Write("輸入台幣(NT):");
    s = Console.ReadLine();
    nt = int.Parse(s);
    Console.Write("輸入幣別(U=USD/J=JPY/E=EUR):");
    curr = Console.ReadLine();
    switch (curr)
    {
        case "U":
        case "u":
            amt = nt / 30.05m;
            break;
        case "J":
        case "j":
            amt = nt / 0.2758m;
            break;
        case "E":
        case "e":
            amt = nt / 32.55m;
            break;
        default:
            amt = 0;
            break;
    }
    Console.WriteLine($"台幣金額{nt:#,##0}, 可兌換金額:{amt:#,##0.00}");
}



