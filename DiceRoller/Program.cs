using System;
using System.Reflection;

Console.WriteLine("Welcome to Grand Circus Casino!\n");

//Roll counter
int roll = 1;

//Restart Program
bool restart = true;
while (restart)
{
    //User Input
    Console.Write("How many sides should each die have? Enter 1-20: ");
    int sides = 0;

    while (!int.TryParse(Console.ReadLine(), out sides) || sides < 0 || sides > 20)
    {
        Console.Write("Invalid entry, Please try again: ");
    }

    //Dice Variables
    int dice1 = GetRandom(sides);
    int dice2 = GetRandom(sides);
    int total = dice1 + dice2;

    //Two Dice roll Outcomes
    Console.WriteLine();
    Console.WriteLine($"Roll {roll++}:");
    Console.WriteLine($"You rolled a {dice1} and a {dice2} ({total} total)");
    if ((total == 7 || total == 11) && sides == 6)
    {
        Console.WriteLine("Win!");
    }
    else if (dice1 == 1 && dice2 == 1 && sides == 6)
    {
        Console.WriteLine("Snake Eyes!\nCraps!");
    }
    else if (dice1 == 6 && dice2 == 6 && sides == 6)
    {
        Console.WriteLine("Box Cars!\nCraps!");
    }
    else if (dice1 == 1 && dice2 == 2 && sides == 6)
    {
        Console.WriteLine("Ace Deuce!\nCraps!");
    }
    else if (dice1 == 2 && dice2 == 1 && sides == 6)
    {
        Console.WriteLine("Ace Deuce!\nCraps!");
    }
    else if ((dice1 == 20 || dice2 == 20) && sides == 20)
    {
        Console.WriteLine("Critical hit!!");
    }
    else if ((dice1 == 1 || dice2 == 1) && sides == 20)
    {
        Console.WriteLine("Miss..");
    }
    else
    {

    }
    Console.WriteLine();

    exitProgram(ref restart);
}

Console.WriteLine("Thank you for playiing!");

//Methods
static int GetRandom(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}

static void exitProgram(ref bool x)
{
    while (true)
    {
        Console.Write("Would you like to roll again? (y/n): ");
        string answer = Console.ReadLine().ToLower().Trim();

        if (answer.Contains('y'))
        {
            Console.Clear();
            break;
        }
        else if (answer.Contains('n'))
        {
            x = false;
            Console.WriteLine();
            break;
        }
        else
        {
            Console.Write("Invalid Entry. Please use (y/n): ");
            Console.WriteLine();
        }
    }
}