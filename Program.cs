int hemligtNummer = 47;

System.Console.WriteLine("Gissa på ett tal mellan 1 och 100");

int gissning = GetInputFromUser();

while (gissning != hemligtNummer)
{
    if (gissning < hemligtNummer)
    {
        Console.WriteLine("Gissa högre");
    }
    else if (gissning > hemligtNummer)
    {
        Console.WriteLine("Gissa lägre");
    }
    gissning = GetInputFromUser();

}
System.Console.WriteLine("Bra gissat!");


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