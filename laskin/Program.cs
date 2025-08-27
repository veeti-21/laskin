Console.WriteLine("minkä laskun haluat tehdä summa = 1 vähennys = 2 kerto = 3 jako = 4. ");
double lasku = double.Parse(Console.ReadLine());
Console.WriteLine("luku 1: ");
double luku1 = double.Parse(Console.ReadLine());
Console.WriteLine("luku 2: ");
double luku2 = double.Parse(Console.ReadLine());

switch (lasku) {
    case 1:
        double summa = luku1 + luku2;
        Console.WriteLine("Summa on: " + summa);            // Käyttäjä syöttää luvun 1 ja 2, sitten laskin laskee ne yhteen ja tulostaa lopputuloksen.  Lasku tapahtuu double- muuttujalla
        break;

        break;
    case 2:
        break;
    case 3:
        static double Kertolasku(double luku1, double luku2)
        {
            return luku1 * luku2;
        }
        Kertolasku(luku1, luku2)
        
        break;
    case 4:// lasketaan jako lasku ja näytetään asiakkaalle 
        double summa = luku1 / luku2;
        Console.WriteLine($"{luku1} / {luku2} = {summa}");
        break;
}

