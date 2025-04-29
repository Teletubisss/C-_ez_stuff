Console.WriteLine("Podaj dzień tygodnia!: ");
string dzien = Console.ReadLine();

switch (dzien)
{
    case "poniedziałek":
        Console.WriteLine("Nowy tydzień!");
        break;
    case "piątek":
        Console.WriteLine("Prawie weekend!");
        break;
    case "sobota":
    case "niedziela":
        Console.WriteLine("Weekend 🎉");
        break;
    default:
        Console.WriteLine("Zwykły dzień tygodnia");
        break;
}
//switch sprawdza, jaki jest dzien. casy itp - czytelniejsze niz if

Console.Write("Podaj liczbę od 1 do 10: ");
string userLiczba = Console.ReadLine();

int liczba = int.Parse(userLiczba);

    switch (liczba)
    {
        case 1:
            Console.WriteLine("Litera: A");
            break;
        case 2:
            Console.WriteLine("Litera: B");
            break;
        case 3:
            Console.WriteLine("Litera: C");
            break;
        case 4:
            Console.WriteLine("Litera: D");
            break;
        case 5:
            Console.WriteLine("Litera: E");
            break;
        case 6:
            Console.WriteLine("Litera: F");
            break;
        case 7:
            Console.WriteLine("Litera: G");
            break;
        case 8:
            Console.WriteLine("Litera: H");
            break;
        case 9:
            Console.WriteLine("Litera: I");
            break;
        case 10:
            Console.WriteLine("Litera: J");
            break;
        default:
            Console.WriteLine("Podano liczbę spoza zakresu 1-10.");
            break;
    }
