Console.WriteLine("Welcome to Twenty-One Card game!");
Console.WriteLine("How many coins are you willing to bet?");

var coins = 0;

try
{
    coins = int.Parse(Console.ReadLine());

    Random rnd = new Random();
    int owner = rnd.Next(1, 21);

    int playerCards = 0;
    Random randomPlayerCards = new Random();

    string finalMessage = "";

    for (int i = coins; i > 0; i--)
    {
        Console.WriteLine($"You have {playerCards} points and {i} tries left. Do you want a new card? Press 1 for Yes and 2 for No.");

        var playerAnswer = 0;

        try
        {
            playerAnswer = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Not a valid option. Please try again");
            i--;
        }

        if (playerAnswer == 1)
        {
            playerCards += randomPlayerCards.Next(1, 12);
            if (playerCards > 21)
            {
                Console.WriteLine("Oh no! You have exceeded the 21 points, you lost :/");
                break;
            }
        }
        else if (playerAnswer == 2)
        {
            Console.WriteLine($"You have ended with {playerCards} points.");
            break;
        }
    }

    Console.WriteLine($"Your total points are {playerCards}. The owner has {owner} points.");

    if (playerCards > owner && playerCards <= 21)
    {
        finalMessage = "Congratulations! You've won!";
    } else
    {
        finalMessage = "You've lost :(";
    }
    Console.WriteLine(finalMessage);

}
catch (Exception ex)
{
    Console.WriteLine("Please only insert numbers.");
}
