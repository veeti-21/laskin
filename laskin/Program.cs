static double Pluslasku(double luku1, double luku2)
{
    return luku1 + luku2;
}
    static double Minuslasku(double luku1, double luku2)
{
    return luku1 - luku2;
}
static double Kertolasku(double luku1, double luku2)
{
    return luku1 * luku2;
}
static double Jakolasku(double luku1, double luku2)
{
    return luku1 / luku2;
}


try
{
    Console.WriteLine("minkä laskun haluat tehdä summa = 1 vähennys = 2 kerto = 3 jako = 4: ");
    double lasku = double.Parse(Console.ReadLine());
    Console.WriteLine("luku 1: ");
    double luku1 = double.Parse(Console.ReadLine());
    Console.WriteLine("luku 2: ");
    double luku2 = double.Parse(Console.ReadLine());

    switch (lasku)
    {
        case 1:
            Console.WriteLine($"summa on: {Pluslasku(luku1, luku2)}");            // Käyttäjä syöttää luvun 1 ja 2, sitten laskin laskee ne yhteen ja tulostaa lopputuloksen.  Lasku tapahtuu double- muuttujalla
            break;
        case 2:
            Console.WriteLine($"summa on: {Minuslasku(luku1, luku2)}");
            break;
        case 3:
            Console.WriteLine($"summa on: {Kertolasku(luku1, luku2)}");
            break;
        case 4:// lasketaan jako lasku ja näytetään asiakkaalle 
            Console.WriteLine($"summa on: {Jakolasku(luku1, luku2)}");
            break;
        default:
            Console.WriteLine("numerota ei ollut listassa");
            break;
    }
} catch { Console.WriteLine("virhe laita numero joka on listassa"); }


