namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ćwiczenia 16.10.2026
            // 4.1
            int a, b;
            Console.Write("Wpisz liczbę a: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Wpisz liczbę b: ");
            b = Convert.ToInt16(Console.ReadLine());

            int suma, roznica, mnoz;

            suma = a + b;
            roznica = a - b;
            mnoz = a * b;

            Console.WriteLine("Wynik dodawania: {0}, Wynik odejmowania: {1}, Wynik mnożenia: {2}", suma, roznica, mnoz);

            if (suma % 2 == 0)
            {
                Console.WriteLine("Wynik sumy jest liczbą parzysty");
            }
            else
            {
                Console.WriteLine("Wynik sumy jest liczbą nieparzystą");
            }

            if (roznica % 2 == 0)
            {
                Console.WriteLine("Wynik odejmowania jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine("Wynik odejmowania jest liczbą nieparzystą");
            }

            if (mnoz % 2 == 0)
            {
                Console.WriteLine("Wynik mnożenia jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine("Wynik mnożenia jest liczbą nieparzystą");
            }


            // 4.2           
            Console.Write("Podaj swoją masę w kilogramach: ");
            double masa = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Podaj swój wzrost w metrach: ");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            double BMI = masa / Math.Pow(wzrost, 2);

            if (BMI < 18.5)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("Prawidłowa waga");
            }
            else
            {
                Console.WriteLine("Nadwaga");
            }


            // 4.3 Kalkulator średniej ocen do stypendium
            int ilosc_przedmiotow = 0;
            Console.Write("Podaj ilość przedmiotów: ");
            ilosc_przedmiotow = Convert.ToInt16(Console.ReadLine());
            double[] oceny = new double[ilosc_przedmiotow];
            double ocena = 0;

            for (int i = 0; i < oceny.Length; i++)
            {
                Console.Write("Ocena nr {0}: ", i + 1);
                ocena = Convert.ToDouble(Console.ReadLine());
                oceny[i] = ocena; 
            }

            double suma = 0;
            foreach (double mark in oceny)
            {
                suma = suma + mark;
            }

            Console.WriteLine("Suma twoich ocen: {0}", suma);

            double srednia = suma / oceny.Length;

            Console.WriteLine("Srednia twoich ocen: {0}", srednia);

            int kwota_stypendium = 0;

            if (srednia >= 2.00 && srednia <= 4.00)
            {
                kwota_stypendium = 0;
                Console.WriteLine("Wysokość stypendium: {0} zł", kwota_stypendium);
            }
            if (srednia >= 4.01 && srednia <= 4.80)
            {
                kwota_stypendium = 1000;
                Console.WriteLine("Wysokość stypendium: {0} zł", kwota_stypendium);
            }
            if (srednia >= 4.81 && srednia <= 5.00)
            {
                kwota_stypendium = 2000;
                Console.WriteLine("Wysokość stypendium: {0} zł", kwota_stypendium);
            }


            // 4.4 Zadanie z dniami tygodnia (zmiana if elsów na switch case'y) Strona 63
            Console.WriteLine("Wpisz nr dnia tygodnia");
            int numer = Convert.ToInt32(Console.ReadLine());
            switch (numer) {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;

                case 2:
                    Console.WriteLine("Wtorek");
                    break;

                case 3:
                    Console.WriteLine("Środa");
                    break;
                
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }


            // 4.5  Kalkulator dla dwóch liczb
            Console.WriteLine("Kalkulator wykonuje dodawanie, odejmowanie, mnożenie i dzielenie dwóch liczb rzeczywistych.");

            Console.Write("Wprowadz pierwsza liczbe: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wprowadz jeden symbol matematyczny: [+; -; *; /] ");
            string math_symbol = Console.ReadLine();

            Console.Write("Wprowadz druga liczbe: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double wynik = 0;
            switch (math_symbol)
            {
                case "+":
                    wynik = a + b;
                    Console.WriteLine("Wynik: {0}",wynik);
                    break;
                case "-":
                    wynik = a - b;
                    Console.WriteLine("Wynik: {0}", wynik);
                    break;
                case "*":
                    wynik = a * b;
                    Console.WriteLine("Wynik: {0}", wynik);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nie mozna dzielic przez 0!");
                    } else {
                        wynik = a / b;
                        Console.WriteLine("Wynik: {0}", wynik);
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidlowy symbol dzialania");
                    break;
            }

            Console.WriteLine("Nacisnij Enter aby zakonczyc program");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
    }
}
