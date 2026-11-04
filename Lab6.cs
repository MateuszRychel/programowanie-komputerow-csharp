namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laboratoria 6 "Tablice" - 23.10.2026
            // Tablica jednowymariowa, foreach, tablica dwuwymariowa i trójwymariowa
            // Podr. 4.12 / 6.1 
            int[,] tablica2d = { { 1, 2 }, { 3, 4 } };
            

            // Przykład 4.12
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            int suma = 0;
            double srednia;
            Console.Write("Wiek uczestników: ");
            foreach (int i in uczestnicy)
            {
                Console.Write("{0}, ", i);
                suma = suma + i;
            }
            srednia = (double)suma / uczestnicy.Length;
            Console.WriteLine();
            Console.WriteLine("Średnia {0}", srednia);
            Console.ReadKey();
            //


            // Podr. Zadanie 4.6 / 6.2
            int liczba = 1;
            int suma = 0;
            int [,,] tablica3d = new int[5, 5, 5];
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        tablica3d[a, b, c] = liczba;
                        liczba++;
                        Console.Write(tablica3d[a, b, c] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                suma = suma + tablica3d[i, i, i];
            }
            Console.WriteLine("Suma: {0}", suma);


            // Zadanie 6.3
            Random rand = new Random();
            int[,] tablica = new int[5, 5];
            Console.WriteLine("Macierz 5x5: ");

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    tablica[x, y] = rand.Next(-5, 6);
                    Console.Write($"{tablica[x,y], 4}");
                }
                Console.WriteLine();
            }

            for (int y = 0; y < 5; y++)
            {
                int min = tablica[0, y];
                int max = tablica[0, y];

                for (int x = 0; x < 5; x++)
                {
                    if (tablica[x, y] < min)
                    {
                        min = tablica[x, y];
                    }

                    if (tablica[x, y] > max)
                    {
                        max = tablica[x, y];
                    }
                }

                Console.WriteLine($"Kolumna {y + 1}: Minimum = {min}, Maksimum = {max}");
            }
            

            // Zadanie 6.4
            Random random = new Random();
            int[,] tabA = new int[3, 3];
            Console.WriteLine("Tablica A:");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tabA[x, y] = random.Next(1, 11);
                    Console.Write(tabA[x, y] + " ");
                }
                Console.WriteLine();
            }

            int[,] tabB = new int[3, 3];
            Console.WriteLine("Tablica B:");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tabB[x, y] = random.Next(1, 11);
                    Console.Write(tabB[x, y] + " ");
                }
                Console.WriteLine();
            }

            int[,] tabC = new int[3, 3];
            Console.WriteLine("Tablica C:");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tabC[x, y] = tabA[x, y] - tabB[x, y];
                    Console.Write(tabC[x, y] + " ");
                }
                Console.WriteLine();


            // Zadanie 6.5
            string[][] towary =
            {
                new string [] { "jabłka", "pomarańcze", "banany", "brzoskwinie" },
                new string [] { "pomidory", "papryki", "marchewki", "cukinia", "sałata" },
                new string [] { "mleczna", "gorzka", "deserowa" } };

            Console.WriteLine("Pętla for: ");
            for (int i = 0; i < towary.Length; i++)
            {
                for (int j = 0; j < towary[i].Length; j++)
                {
                    Console.WriteLine(towary[i][j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Pętla foreach: ");
            foreach (string[] podtablica in towary) 
            {
                foreach (string i in podtablica)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pętla for w odwróconej kolejności: ");
            for (int i = towary.Length-1; i >= 0; i--) 
            {
                for (int j = towary[i].Length-1; j >= 0; j--)
                {
                    Console.WriteLine(towary[i][j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Pętla foreach w odwróconej kolejności: ");
            foreach (string[] podtablica in towary.Reverse())
            {
                foreach (string i in podtablica.Reverse())
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }
    }
}
