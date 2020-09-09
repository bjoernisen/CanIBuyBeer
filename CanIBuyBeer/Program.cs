using System;

// om ålder > 17 OCH location == "krogen" OCH om leg == "j" OCH om promille < 1.0 JA
// om ålder > 19 och location == "systemet" OCH om leg == "j" OCH om promille < 1.0 JA


namespace CanIBuyBeer
{
    class Program
    {
        static bool CanIBuyBeers(int age, string location, string leg, decimal promille)
        {
            if (leg !="j")
                return false;
            if (promille > 1.0m)
                return false;
            if (age > 15 && location =="skolan")
                return true;
            if (age > 17 && location =="krogen")
                return true;
            if (age > 19 && location =="systemet")
	            return true; 
            return false;
        }
    static void Main(string[] args)
    {
        Console.WriteLine("Tjena tjena mittbena");
        Console.Write("Hur gammal är du?: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Location, systemet eller krogen?: ");
        string location = Console.ReadLine().ToLower();
        Console.Write("Har du leg med dig? (J/N): ");
        string leg = Console.ReadLine().ToLower();
        Console.Write("Vilken promillehalt har du?: ");
        decimal promille = Convert.ToDecimal(Console.ReadLine());

        bool beer = CanIBuyBeers(age, location, leg, promille);

        if (beer == true)
        {
            Console.WriteLine("Du får köpa öl");
        }
        else
        {
            Console.WriteLine("Du får INTE köpa öl");
        }
    }
}
}

