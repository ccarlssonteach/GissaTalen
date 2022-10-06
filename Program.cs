int hemligtNummer = 47;

System.Console.WriteLine("Gissa på ett tal mellan 1 och 100");

int gissning = int.Parse(Console.ReadLine());

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
    gissning = int.Parse(Console.ReadLine());

}
System.Console.WriteLine("Bra gissat!");

