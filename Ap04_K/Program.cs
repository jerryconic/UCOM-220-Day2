string s;
int principal, n;
double rate;

Console.Write("本金=");
s=Console.ReadLine();
principal=int.Parse(s);

Console.Write("利率(%)=");
s = Console.ReadLine();
rate = double.Parse(s);

Console.Write("期數=");
s = Console.ReadLine();
n = int.Parse(s);

Console.WriteLine("期數  本      金  利      息  合      計");
Console.WriteLine("====  ==========  ==========  ==========");
for (int i = 0; i <= n; i++)
{
    int interest = (int)(principal * rate / 100 + 0.5);
    Console.WriteLine("{0,4}{1,12:#,##0}{2,12:#,##0}{3,12:#,##0}", i,principal,interest, principal+interest); 
    //                         |  |
    //                         |  定義數值格式
    //                         總共佔12位(含前面2位括號)
    principal += interest;
}
Console.WriteLine("====  ==========  ==========  ==========");
