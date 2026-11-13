// Zadanie 8.1
/*
 * Napisz program, który pobiera od użytkownika tekst, a następnie:
 * - zamienia wszystkie litery na wielkie,
 * - odwraca kolejność liter w tekście.
 * Na końcu wyświetla zmieniony tekst.
 */

Console.WriteLine("Podaj tekst: ");
string napis = Console.ReadLine();
napis = napis.ToUpper();
napis = new string(napis.Reverse().ToArray());
Console.WriteLine(napis);


// Zadanie 8.2
Console.WriteLine("Podaj tekst: ");
string napis = Console.ReadLine();
int ilosc = 0;
bool is_word = false;
foreach (char znak in napis)
{
    if (znak != ' ')
    {
        if (!is_word)
        {
            ilosc++;
            is_word = true;
        }
    }
    else
    {
        is_word = false;
    }
}
Console.WriteLine("Ilośc wyrazów: {0}", ilosc);


// Zadanie 8.3
Console.WriteLine("Program szyfru cezaara, podaj tekst do zaszyfrowania: ");
string text = Console.ReadLine() ?? "";
Console.WriteLine("O ile przesuwasz litery? ");
int n = Convert.ToInt16(Console.ReadLine());
int zm_wart = 0;
string zaszyfrowany = "";

Console.WriteLine("Zaszyfrowany tekst: ");

foreach (char litera in text)
{
    if (litera >= 'a' && litera <= 'z')
    {
        zm_wart = (((int)litera - 97 + n) % 26 + 26) % 26 + 97;
        zaszyfrowany += (char)zm_wart;
    }
    else if (litera >= 'A' && litera <= 'Z')
    {
        zm_wart = (((int)litera - 65 + n) % 26 + 26) % 26 + 65;
        zaszyfrowany += (char)zm_wart;
    }
    else
    {
        zaszyfrowany += litera;
    }
}
Console.WriteLine(zaszyfrowany);


// Zadanie 8.4
while (true)
{
    Console.Clear();
    Console.Write("Wpisz słowo: ");
    string word = Console.ReadLine() ?? "";

    word = word.ToLower().Replace(" ", "");

    string odwrocone = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        odwrocone += word[i];
    }

    if (word == odwrocone)
    {
        Console.WriteLine("Jest to palindrom");
    }
    else
    {
        Console.WriteLine("Nie jest to palindrom");
    }

    Console.ReadKey();
}


// Zadanie 8.5 
string napis = "ala ma kota";
string napis2 = "ALA MA KOTA";

// Polecenie 1 - porównanie napisów
int wynik = String.Compare(napis, napis2, false);
Console.WriteLine("Porównanie z uwzględnieniem wielkości liter: {0}", wynik);

int wynik2 = String.Compare(napis, napis2, true);
Console.WriteLine("Porównanie bez uwzględnienia wielkości liter: {0}", wynik2);

// Polecenie 2 - połączenie napisów
string tekstSklejony = string.Concat(napis, " ", napis2);
Console.WriteLine("Wynik połączenia obu tekstów: {0}", tekstSklejony);

// Polecenie 3 - długość pierwszego napisu
int dlugosc = napis.Length;
Console.WriteLine("Długość pierwszego napisu: {0}", dlugosc);

// Polecenie 4 - trzeci znak drugiego napisu
char znak = napis2[2];
Console.WriteLine("Znak znajdujący się na trzecim miejscu: {0}" , znak);

// Polecenie 5 - pierwsze wystąpienie słowa "ma"
int indeks = napis.IndexOf("ma");
Console.WriteLine("Pierwsze wystąpienie słowa 'ma': {0}", indeks);

// Polecenie 6 - wstawienie wyrażenia "psa i "
string napis3 = napis.Insert(7, "psa i ");
Console.WriteLine("Wynik po wstawieniu wyrażenia: {0}", napis3);
