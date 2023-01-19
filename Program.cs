
using System.Diagnostics.Metrics;

Console.WriteLine("Welcome to the Grand Circus Casino!");
Console.WriteLine("How many sides should each die have?");

int diceSide = 0;
int roll1 = 0;
int roll2 = 0;
int sum = 0;
string combo = "";
bool runProgram = true;
int count = 0;
int dnd1 = 0;
int dnd2 = 0;
while (int.TryParse(Console.ReadLine(), out diceSide) == false) // or put ! before int.TryParse for ==false
{
    Console.WriteLine("Not a number. Try again");
}
//Console.WriteLine(diceSide);
//while (true)
//{
while (runProgram)
{
    count++;
    roll1 = GetRandom2(diceSide);
    roll2 = GetRandom2(diceSide);
    Console.WriteLine($"\nRoll #{count}:");
    Console.WriteLine($"You rolled a {roll1} and a {roll2} for a total of ({roll1 + roll2})");
    if (diceSide == 6)
    {
        Console.WriteLine(ValidCombo(roll1, roll2));
        Console.WriteLine(ValidTotal(roll1, roll2));
    }
    if (diceSide == 20)
    {
        Console.WriteLine(d20(roll1, roll2));
    }
    while (true)
    {
        Console.Write("\nWould you like to roll again? (y/n)");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            Console.WriteLine("Thanks for playing!");
            runProgram = false;
            break;
        }
        else if (choice == "y")
        {
            runProgram = true;
            break;
        }
    }
}

   


//Getting random numbers

//static int GetRandom()
//{
//    Random r = new Random();
//    //return r.Next(6); //0-5
//    return r.Next(1, 7); //1-6
//}

static int GetRandom2(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}


//Valid Combo string
static string ValidCombo(int roll1, int roll2)
{

    if (roll1 == 1 && roll1 == roll2)
    {
        Console.WriteLine("Snakeyes!");
    }
    else if (roll1 == 6 && roll1 == roll2)
    {
        Console.WriteLine("Box Cars!");
    }
    else if (roll1 ==1 && roll2==2)
    {
        Console.WriteLine("Ace Deuce!");
    }
    else if (roll1 ==2 && roll2==1)
    {
        Console.WriteLine("Ace Deuce!");
    }
    else
    {
        Console.WriteLine("");
    }
    return "";
}
//Creatures and Catacombs


//Valid Sum string
static string ValidTotal(int roll1, int roll2)
{
    if (roll1 + roll2 == 7 || roll1 + roll2 == 11)
    {
        Console.WriteLine("You Win!");
    }
    else if (roll1 + roll2 == 2 || roll1 + roll2 == 3 || roll1+roll2==12)
    {
        Console.WriteLine("Craps!");
    }
    return "";
}


static string d20(int roll1, int roll2)
{
    if (roll1 + roll2 == 40 )
    {
        Console.WriteLine("Critical Success! Not only do you avoid stepping on the banana peel by doing a quadruple front flip over it, you also manage to land on your feet before reaching the staircase to the bottomless pit!");
    }
    else if (roll1 + roll2 == 2)
    {
        Console.WriteLine("Failure! You slip on the banana peel and fall down 10 flights of stairs into a bottomless pit! Unfortunate!");
    }
    else if( roll1+ roll2 == 1)
    {
        //this shouldnt be possible
        Console.WriteLine("Critical failure. You spontaneously combust and then die from a suddent heart attack.");
    }
    return "";
}