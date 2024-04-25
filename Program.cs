
AppInfo();

while (true)
{
    // generate random number
    Random rand = new Random();
    int ans = rand.Next(1, 9);
    // set base values
    int init = 0;

    // prompt user
    Console.WriteLine("I have a number btwn 1 and 9, guess the number");

    while (init != ans)
    {
        try
        {
            // get user's guess
            init = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Invalid input");
            // user prolly enterd an alphabet/special char
        }

        if (ans != init)
        {
            SetResetColor(ConsoleColor.Red, "Wrong, try again!");
        }
        else
        {
            SetResetColor(ConsoleColor.Green, "Yeah, you got it");
        }
    }

    Console.WriteLine("Wanna play again? [Y Or N]");
    string cont = Console.ReadLine().ToUpper();
    if (cont == "Y")
    {
        continue;
    }
    else
    {
        SetResetColor(ConsoleColor.Yellow, "Thanks for playing");
        break;
    }
}
// do rock, paper and scissors

static void AppInfo()
{
    int age = 18;
    string room = "Guess Room";
    Console.WriteLine("Welcome to {0} strictly {1}+", room, age);

    // get user's name
    Console.WriteLine("Please enter your name: ");
    string user = Console.ReadLine();
    Console.WriteLine("Welcome {0}", user);

}

static void SetResetColor(ConsoleColor color, string msg)
{
    Console.ForegroundColor = color;
    Console.WriteLine(msg);
    Console.ResetColor();
}