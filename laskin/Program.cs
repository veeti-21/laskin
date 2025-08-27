Console.WriteLine("minkä laskun haluat tehdä summa = 1 vähennys = 2 kerto = 3 jako = 4. ");
int lasku = int.Parse(Console.ReadLine());
Console.WriteLine("luku 1: ");
int luku1 = int.Parse(Console.ReadLine());
Console.WriteLine("luku 2: ");
int luku2 = int.Parse(Console.ReadLine());

switch (lasku) {
    case 1:
        int summa = luku1 + luku2;
        Console.WriteLine("Summa on: " + summa);            // Käyttäjä syöttää luvun 1 ja 2, sitten laskin laskee ne yhteen ja tulostaa lopputuloksen.
        break;

        break;
    case 2:
        break;
    case 3:
        break;
    case 4:
        break;

}

