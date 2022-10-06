int hemligtNummer = 47;

System.Console.WriteLine("Gissa på ett tal mellan 1 och 100");

int gissning = GetInputFromUser();

while (!CheckGuess(gissning, hemligtNummer))
{
    gissning = GetInputFromUser();
}

System.Console.WriteLine("Bra gissat!");


bool CheckGuess(int guess, int secret)
{
    if (guess < secret)
    {
        Console.WriteLine("Gissa högre");
        return false;
    }
    else if (guess > secret)
    {
        Console.WriteLine("Gissa lägre");
        return false;
    }
    return true;
}

int GetInputFromUser()
{
    int result;
    string input = Console.ReadLine();
    while (!int.TryParse(input, out result))
    {
        Console.Write("Felakting inmatning, försök igen: ");
        input = Console.ReadLine();
    }
    return result;
}