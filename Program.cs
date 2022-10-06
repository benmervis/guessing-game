// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;


Random random = new Random();

int winNum = random.Next(0, 100);

bool win = false;

do
{
    Console.WriteLine("Guess a number in between 0 and 100: ");
    string s = Console.ReadLine();

    int i = int.Parse(s);

    if (i > winNum)
        Console.WriteLine("too high!! guess lower!");
    else if (i < winNum)
        Console.WriteLine("too low!! guess higher!");
    else if (i == winNum)
    {
        Console.WriteLine("YOU WIN!");
        win = true;
    }

} while (win == false);
