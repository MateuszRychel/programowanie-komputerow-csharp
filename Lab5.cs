namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i < 41; i=i+20)
            {
                Console.WriteLine(i);
            }
          

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("i: {0}, j: {1}", i, j);
                }
            } // 5 * 5


            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
            i++;

            // Zadanie domowe: Możliwość DateTime.now i operacji na datach

            int x;
            do
            {

            } while

            int i = 0;
            do
            {
                Console.WriteLine(++i);
            } while (i <= 10);

            // 5.1
            for (int i = 1; i <= 11; ++i)
            {
               Console.WriteLine(i);
            }


            // 5.2
            Console.Write("Podaj liczbę wierszy: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(((j + 1) * i) + " ");
                }
                Console.WriteLine(" ");
            }

            // 5.3
            Console.WriteLine("Program obliczający pole prostokąta.");
            double pole = 1;
            int i = 0;
            while (i < 2)
            {
                Console.Write("Podaj długość boku: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Długość boku musi być dodatnia");
                } else
                {
                    pole = pole * x;
                    i++;
                }   
            }
            Console.WriteLine("Pole prostokąta: " + pole);
            */

            // 5.4
            Console.WriteLine("Witamy w programie dotyczącym sposobu oszczędzania");
            Console.WriteLine("Wariant 1: 1000 zł każdego roku");
            Console.WriteLine("Wariant 2: 1 zł dziennie, kwota podwajana co roku");
    
            Console.Write("Podaj ilość lat oszczędzania: ");
            int n = Convert.ToInt32(Console.ReadLine());
    
            if (n <= 0)
            {
                Console.WriteLine("Liczba lat musi być dodatnia.");
                return;
            }
    
            long wariant1 = (long)n * 1000;
            Console.WriteLine("Kwota oszczędzona przy wariancie 1: {0} zł", wariant1);
    
            long wariant2 = 0;
            long kwota = 365;
    
            while (n > 0)
            {
                wariant2 += kwota;
                kwota *= 2;
                n--;
            }
    
            Console.WriteLine("Kwota oszczędzona przy wariancie 2: {0} zł", wariant2);
    
            if (wariant1 > wariant2)
            {
                Console.WriteLine("Wariant 1 jest korzystniejszy.");
            }
            else if (wariant1 < wariant2)
            {
                Console.WriteLine("Wariant 2 jest korzystniejszy.");
            }
            else
            {
                Console.WriteLine("Oba warianty dają taką samą kwotę.");
            }

                      /*
           * ZADANIE 3.9
           * Wyświetlanie czterech figur z gwiazdek
           */
          
          Console.Write("Podaj ilość wierszy: ");
          int ilosc_wierszy = Convert.ToInt32(Console.ReadLine());
          
          if (ilosc_wierszy > 0)
          {
              // Figura A
              Console.WriteLine("Figura A:");
          
              for (int i = 1; i <= ilosc_wierszy; i++)
              {
                  for (int j = 0; j < i; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
          
              Console.WriteLine();
          
              // Figura B
              Console.WriteLine("Figura B:");
          
              for (int i = ilosc_wierszy; i > 0; i--)
              {
                  for (int j = i; j > 0; j--)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
          
              Console.WriteLine();
          
              // Figura C
              Console.WriteLine("Figura C:");
          
              for (int i = 1; i <= ilosc_wierszy; i++)
              {
                  for (int j = 0; j < ilosc_wierszy - i; j++)
                  {
                      Console.Write(" ");
                  }
          
                  for (int j = 0; j < i; j++)
                  {
                      Console.Write("*");
                  }
          
                  Console.WriteLine();
              }
          
              Console.WriteLine();
          
              // Figura D
              Console.WriteLine("Figura D:");
          
              for (int i = 0; i < ilosc_wierszy; i++)
              {
                  for (int j = 0; j < ilosc_wierszy; j++)
                  {
                      if (j == 0 || j == ilosc_wierszy - 1 ||
                          i == 0 || i == ilosc_wierszy - 1)
                      {
                          Console.Write("*");
                      }
                      else
                      {
                          Console.Write(" ");
                      }
                  }
                  Console.WriteLine();
              }
          }
          else
          {
              Console.WriteLine("Liczba wierszy musi być dodatnia.");
          }
          
          /*
           * ZADANIE 3.10
           * Obliczanie silni
           */
          
          Console.WriteLine();
          Console.Write("Podaj liczbę do obliczenia silni: ");
          int n = Convert.ToInt32(Console.ReadLine());
          
          int wynik = 1;
          
          if (n < 0 || n > 12)
          {
              Console.WriteLine("Podaj liczbę od 0 do 12.");
          }
          else
          {
              while (n > 0)
              {
                  wynik = wynik * n;
                  n--;
              }
          
              Console.WriteLine("Silnia wynosi: " + wynik);
          }
          
          /*
           * ZADANIE 3.11
           * Sumowanie kolejnych liczb od 1,
           * aż suma przekroczy 100
           */
          
          Console.WriteLine();
          Console.WriteLine("Zadanie 3.11:");
          
          int liczba = 1;
          int ilosc = 0;
          int suma = 0;
          
          while (suma <= 100)
          {
              suma = suma + liczba;
              liczba++;
              ilosc++;
          }
          
          Console.WriteLine("Ilość liczb: " + ilosc);
          Console.WriteLine("Suma: " + suma);
    }
}
