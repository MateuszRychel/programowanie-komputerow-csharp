// Zadanie 7.1
string[] marki_slodyczy = { "Wedel", "Nestle", "Wawel", "Goplana", "Solidarność", 
    "Bałtyk", "Hanka", "Ferrero", "Storck", "Mondelez" };

Console.WriteLine("Zastosowanie metody Reverse: ");
Array.Reverse(marki_slodyczy);
foreach (string nazwa in marki_slodyczy)
{
    Console.WriteLine(nazwa);
}

Console.WriteLine("");
Console.WriteLine("Wygląd array po metodzie Reverse: ");
foreach (string nazwa in marki_slodyczy)
{
    Console.WriteLine(nazwa);
}

Console.WriteLine("");
Console.WriteLine("Metoda sort (alfabetycznie): ");
Array.Sort(marki_slodyczy);
foreach (string nazwa in marki_slodyczy)
{
    Console.WriteLine(nazwa);
}

Console.WriteLine("");
string[] tabela = Array.FindAll(marki_slodyczy, nazwa => nazwa.StartsWith("W")); //Kopiowanie marek zaczynających się na literę W

foreach (string nazwa in tabela)
{
    Console.WriteLine(nazwa);
}

for (int g = 0; g < tabela.Length; g++)
{
    Console.WriteLine(tabela[g]);
}

Console.WriteLine("");
Console.WriteLine("Indeks marki Goplana: ");
Console.WriteLine(Array.IndexOf(marki_slodyczy, "Goplana"));


// Zadanie 7.2
double[] ceny = { 3.43, 5.26, 6.15, 3.43, 2.22, 10.99, 3.51, 4.55, 7.21, 9.64 };
Console.WriteLine("Pierwsze wystąpienie wartości 3.43: ");
Console.WriteLine(Array.IndexOf(ceny, 3.43));
Console.WriteLine("Ostanie wystąpienie wartości 3.43: ");
Console.WriteLine(Array.LastIndexOf(ceny, 3.43));

Array.Sort(ceny);

double[] ceny_z_Vat = new double[10];

for (int j=0; j < ceny.Length; j++)
{
    ceny_z_Vat[j] = ceny[j] * 1.08;
}

Console.WriteLine("Ceny z uwzględniem podatku Vat 8%: ");
foreach (double cena in ceny_z_Vat)
{
    Console.WriteLine(cena);
}

    
// Zadanie 7.3
double[] ceny_obuwia = new double[20];
int[] il_sprzedanych_szt = new int[20];
double[] wartosc_sprzedazy = new double[20];

Random random = new Random();

// Losowanie danych i obliczanie wartości sprzedaży
for (int j = 0; j < ceny_obuwia.Length; j++)
{
    ceny_obuwia[j] = Math.Round(random.NextDouble() * 250 + 50, 2);

    il_sprzedanych_szt[j] = random.Next(1, 101);

    wartosc_sprzedazy[j] = Math.Round(
        ceny_obuwia[j] * il_sprzedanych_szt[j], 2);
}

// Wyświetlenie cen obuwia
Console.WriteLine("Ceny obuwia:");

for (int j = 0; j < ceny_obuwia.Length; j++)
{
    Console.WriteLine("Cena obuwia: {0:F2} zł", ceny_obuwia[j]);
}

// Wyświetlenie ilości sprzedanych par
Console.WriteLine("\nIlość sprzedanych par:");

for (int j = 0; j < il_sprzedanych_szt.Length; j++)
{
    Console.WriteLine("Ilość sprzedanych par: {0}",
        il_sprzedanych_szt[j]);
}

// Wyświetlenie wartości sprzedaży
Console.WriteLine("\nWartości sprzedaży:");

for (int j = 0; j < wartosc_sprzedazy.Length; j++)
{
    Console.WriteLine("Wartość sprzedaży: {0:F2} zł",
        wartosc_sprzedazy[j]);
}

// Stworzenie czwartej tablicy
double[] posortowane_wyniki_sprzedazy = new double[20];

// Kopiowanie danych
Array.Copy(wartosc_sprzedazy, posortowane_wyniki_sprzedazy, 20);

// Sortowanie danych
Array.Sort(posortowane_wyniki_sprzedazy);

// Wyświetlenie posortowanych wartości
Console.WriteLine("\nPosortowane wartości sprzedaży:");

foreach (double wartosc in posortowane_wyniki_sprzedazy)
{
    Console.WriteLine("{0:F2} zł", wartosc);
}


// Zadanie 7.4
string[] autorzy = new string[10];
for (int i = 0; i < autorzy.Length; i++)
{
    Console.Write("Podaj nazwisko autora {0}: ", i + 1);
    autorzy[i] = Console.ReadLine();
}

string[] tabela2 = new string[4];
for (int i = 0; i < tabela2.Length; i++)
{
    tabela2[i] = autorzy[i];
}
Array.Sort(tabela2);
Array.Reverse(tabela2);

foreach (string autor in tabela2)
{
    Console.WriteLine(autor);
}
