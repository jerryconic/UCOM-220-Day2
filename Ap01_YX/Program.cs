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

}
void CalcTax()
{

}

void Exchange()
{

}



