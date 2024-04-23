Random rnd = new Random();

for (; ; )
{
    int[] dices = new int[4];

    for (int i = 0; i < dices.Length; i++)
        dices[i] = rnd.Next(1, 7);

    Array.Sort(dices);

    for (int i = 0; i < dices.Length; i++)
        Console.Write($"{dices[i]} ");
    Console.WriteLine();

    if (dices[0] == dices[3])
        Console.WriteLine("一色");
    else if (dices[0] == dices[2] || dices[1] == dices[3])
        Console.WriteLine("沒點重擲(3)");
    else if (dices[0] == dices[1])
        Console.WriteLine($"{dices[2] + dices[3]}點");
    else if (dices[1] == dices[2])
        Console.WriteLine($"{dices[0] + dices[3]}點");
    else if (dices[2] == dices[3])
        Console.WriteLine($"{dices[0] + dices[1]}點");
    else
        Console.WriteLine("沒點重擲(1)");

    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.WriteLine();

}