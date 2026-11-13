// Zadanie 9.1
Console.WriteLine("Podaj przekroczenie predkosci (20, 30, 50) km/h: ");
int przekroczenie_predkosci = Convert.ToInt16(Console.ReadLine());

switch (przekroczenie_predkosci)
{
    case 20:
        Console.WriteLine("Mandat wynosi 50 zł");
        goto Koniec;
    
    case 30:
        Console.WriteLine("Mandat wynosi 100 zł");
        goto Koniec;
    
    case 50:
        Console.WriteLine("Mandat wynosi 200 zł");
        goto Koniec;
    
    default:
        Console.WriteLine("Nieprawidlowe przekroczenie predkosci");
        goto Koniec;
}
Koniec:
    Console.WriteLine("Koniec programu");


// Zadanie 9.2
Console.WriteLine("Program obliczający przyszłą wartość lokaty bankowej");
Console.WriteLine("Podaj kwotę początkową: ");
double kwota_poczatkowa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj liczbę lat: ");
int lata = Convert.ToInt32(Console.ReadLine());
double oprocentowanie = 0.011;
int kapitalizacja = 12;

for (int i = 1; i <= lata; i++)
{
    double wartosc_po_roku = kwota_poczatkowa * Math.Pow(1 + oprocentowanie / kapitalizacja, kapitalizacja * i);
    Console.WriteLine($"Wartość lokaty po {i} roku wynosi: {wartosc_po_roku:F2} zł");
}


// Zadanie 9.3
Random random = new Random();
int[] tablica = new int[20];
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = random.Next(1, 101);
}

Console.WriteLine("Wygląd tablicy: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}

int suma = 0;
for (int i = 0; i < tablica.Length; i++)
{
    suma += tablica[i];
}

double srednia = (double)suma / tablica.Length;
Console.WriteLine($"\nSrednia wartosc elementow tablicy wynosi: {srednia:F2}");

int il_mniejszych_el = 0;
int il_wiekszych_el = 0;
for (int i = 0; i < tablica.Length; i++)
{
    if (tablica[i] < srednia)
    {
        Console.WriteLine($"Element {tablica[i]} jest mniejszy od średniej");
        il_mniejszych_el++;
    }
    if (tablica[i] > srednia)
    {
        Console.WriteLine($"Element {tablica[i]} jest większy od średniej");
        il_wiekszych_el++;
    }
}

Console.WriteLine($"Liczba elementów mniejszych od średniej: {il_mniejszych_el}");
Console.WriteLine($"Liczba elementów większych od średniej: {il_wiekszych_el}");

Array.Reverse(tablica);
foreach (int element in tablica)
{
    Console.Write(element + " ");
}
