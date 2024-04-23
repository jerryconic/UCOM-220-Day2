string s;
int principal, n;
double rate;

Console.WriteLine("本金:");
s = Console.ReadLine();
principal = int.Parse(s);

Console.WriteLine("利息:");
s = Console.ReadLine();
rate = int.Parse(s);

Console.WriteLine("期數");
s = Console.ReadLine();
n = int.Parse(s);

Console.WriteLine("期數  本      金  利      息  合      計");   //中字占2bit 中間空格6bit(不含前面2格bit)
Console.WriteLine("====  ==========  ==========  ==========");
for (int i = 1; i <= n; i++) 
{
    int interest = (int)(principal * rate / 100 + 0.5);
    Console.WriteLine("{0,4}{1,12:#,##0}{2,12:#,##0}{3,12:#,##0}", i, principal, interest, principal + interest);
    //Console.WriteLine($"{i,4},{principal,12},{principal + interest,12}"); 也可以這樣(*若直接以n來用期數會相同，所以用i)
    principal += interest;
}
Console.WriteLine("====  ==========  ==========  ==========");
