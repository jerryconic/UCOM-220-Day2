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
Console.WriteLine();

for (int i = n; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
        Console.Write(" ");
    for (int j = 1; j <= 2*i-1; j++)
        Console.Write("*");
    Console.WriteLine();
}

