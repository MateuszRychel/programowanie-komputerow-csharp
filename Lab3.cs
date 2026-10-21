namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.1 Dlugosc odc |AB| w ukladzie wspolrzednych
            
            //Współrzędne punktu A
            int x1; 
            int y1;

            //Współrzędne punktu B
            int x2;
            int y2;

            double dl_odcinka;
            Console.WriteLine("Podaj współrzędne pkt A: ");
            Console.Write("x: ");
            x1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("y: ");
            y1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Podaj współrzędne pkt B: ");
            Console.Write("x: ");
            x2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("y: ");
            y2 = Convert.ToInt16(Console.ReadLine());
            
            dl_odcinka = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            dl_odcinka = Math.Sqrt(dl_odcinka);
            Console.WriteLine("Dlugosc odcinka |AB| wynosi: {0}", dl_odcinka);


            // 3.3
            Console.WriteLine("Wybierz figurę:\r\n 1)kwadrat\r\n 2)prostokąt\r\n 3)trójkąt\r\n 4)koło\r\n 5)trapez");
            int Figura = Convert.ToInt16(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;
            int h = 0;
            double r = 0;
            const double PI = Math.PI;
            double obw = 0;
            double pole = 0;
            switch (Figura)
            {
                case 1:
                    Console.Write("Wpisz długość boku a: ");
                    a = Convert.ToUInt16(Console.ReadLine());
                    obw = 4 * a;
                    pole = a * a;
                    Console.WriteLine($"Obwód: {obw,-15} Pole: {pole,-20}");
                    break;

                case 2:
                    Console.Write("Wpisz długość boku a: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Wpisz długość boku b: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    obw = 2 * a + 2 * b;
                    pole = a * b;
                    Console.WriteLine("Obwód: {0, -15} Pole: {1, -20}", obw, pole);
                    break;

                case 3:
                    Console.Write("Wpisz długość boku a: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Wpisz długość boku b: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Wpisz długość boku c: ");
                    c = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Wpisz długość boku h: ");
                    h = Convert.ToInt16(Console.ReadLine());
                    obw = a + b + c;
                    pole = Convert.ToDouble((a * h) / 2);
                    Console.WriteLine("Obwód: {0, -15} Pole: {1, -20}", obw, pole);
                    break;

                case 4:
                    Console.Write("Wpisz długość promienia r: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    obw = 2 * PI * r;
                    pole = Convert.ToDouble((PI * r * r));
                    Console.WriteLine("Obwód: {0, -15:F4} Pole: {1, -20:F4}", obw, pole);
                    break;

                case 5:
                    Console.Write("Wpisz długość boku a: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Wpisz długość boku b: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Wpisz długość boku h: ");
                    h = Convert.ToInt16(Console.ReadLine());
                    obw = 2 * a + 2 * b;
                    pole = Convert.ToDouble((a + b) * h / 2);
                    Console.WriteLine("Obwód: {0, -15} Pole: {1, -20}", obw, pole);
                    break;

                default:
                    Console.WriteLine("Błąd");
                    break;
            }
            Console.ReadLine();


            // 3.4
            int il_towarow = 0;
            string kod;
            string nazwa_towaru;
            double cena;
            int ilosc;

            Console.WriteLine("Witamy w programie hurtowni XYZ.");
            Console.WriteLine("Wprowadź dane towarów: ");

            string[] kody_towarow = new string[4];
            string[] nazwy_towarow = new string[4];
            double[] ceny_towarow = new double[4];
            int [] ilosc_towarow = new int[4];

            while (il_towarow < 4) 
            {
                Console.WriteLine("\nTowar nr {0}", il_towarow + 1);

                Console.Write("Wprowadź kod towaru: ");
                kod = Console.ReadLine();
                kody_towarow[il_towarow] = kod;

                Console.Write("Wprowadź nazwę towaru: ");
                nazwa_towaru = Console.ReadLine();
                nazwy_towarow[il_towarow] = nazwa_towaru;

                Console.Write("Wprowadź cenę towaru: ");
                cena = Convert.ToDouble(Console.ReadLine());
                ceny_towarow[il_towarow] = cena;

                Console.Write("Wprowadź ilość na stanie tego towaru: ");
                ilosc = Convert.ToInt32(Console.ReadLine());
                ilosc_towarow[il_towarow] = ilosc;

                il_towarow = il_towarow + 1;
            }

            Console.WriteLine();
            Console.WriteLine("{0,-15} {1,-25} {2,12} {3,10}",
                "Kod towaru", "Nazwa towaru", "Cena", "Ilość");

            Console.WriteLine(new string('-', 65));

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,-15} {1,-25} {2,9:F2} zł {3,10}",
                    kody_towarow[i],
                    nazwy_towarow[i],
                    ceny_towarow[i],
                    ilosc_towarow[i]);
            }


            // 3.5
            int iloscRat = 0;
            int wiek = 0;
            int status = 0;
            int hipoteka = 0;
            int zyrant = 0;
            float zarobki = 0;
            float wysokoscKredytu = 0;
            bool decyzja;

            Console.WriteLine("Witamy w banku XYZ");
            Console.WriteLine("By uzyskac kredyt odpowiedz na kilka pytan");
            Console.WriteLine();
            Console.WriteLine("Ile masz lat?");
            wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jaki masz status? 1) Pracuje 2) Emeryt");
            status = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile zarabiasz?");
            zarobki += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile chcesz wziąć kredytu?");
            wysokoscKredytu += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Na ile rat?");
            iloscRat = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Czy masz hipoteke? 1) Tak 2) Nie");
            hipoteka = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Czy masz żyrantów? 1) Tak 2) Nie");
            zyrant = Convert.ToInt16(Console.ReadLine());

            if (wiek >= 18 && status == 1 && (zarobki >= (wysokoscKredytu / iloscRat) * 0.2) && hipoteka == 2 || zyrant == 1)
            {
                decyzja = true;
                Console.WriteLine("Możesz dostać Kredyt. {0}", decyzja);
            }
            else
            {
                decyzja = false;
                Console.WriteLine("Nie możesz dostać Kredytu. {0}", decyzja);
            }
            Console.ReadLine();
        }
    }   
}
