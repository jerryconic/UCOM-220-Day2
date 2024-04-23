/*
 * 畫星星
 */

string s;
int n;
Console.Write("n=");
s = Console.ReadLine();
n = int.Parse(s);
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}