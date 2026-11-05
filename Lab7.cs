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

//Kopiowanie marek zaczynających się na literę W
Console.WriteLine("")
string[] tabela = {};
int i = 0;
foreach (string nazwa in marki_slodyczy)
{
    if (nazwa[0] == 'W')
    {
        Array.Copy(marki_slodyczy, nazwa, tabela, i, marki_slodyczy.Length);
        Console.WriteLine(nazwa);
        i++;
    }
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
