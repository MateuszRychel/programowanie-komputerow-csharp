namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wykład 2 - Programowanie komputerów 9.10.2026, 3 zajęcia

            /*
            int x = 1, y;
            Console.WriteLine(++x);
            Console.WriteLine(x++);
            Console.WriteLine(x);
            y = x++;
            Console.WriteLine(y);
            y = ++x;
            Console.WriteLine(++y);
            */

            /*
            double x, y;
            Console.WriteLine("Podaj x większego od 0: ");
            x = Console.Read();
            dokończyć s.35
            */


            /*
            double wiek, PLN;
            bool kino;
            Console.WriteLine("Podaj swój wiek: ");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniędzy: ");
            PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20);
            Console.WriteLine(kino);
            Console.ReadKey();
            */


            //Zadanie 2.9 s.56
            /*
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            */
            /* && jeśli mamy dwa warunki: pierwszy fałszywy to drugi już nie jest sprawdzan */


            //Console.WriteLine("Wpisz figurę:\r\n 1)kwadrat\r\n 2)prostokąt\r\n 3)trójkąt\r\n 4)koło\r\n 5)trapez");
            //int Figura = Convert.ToInt16(Console.ReadLine());
            //int a = 0;
            //int b = 0;
            //int c = 0;
            //int h = 0;
            //int r = 0;
            //const double PI = Math.PI;
            //int obw = 0;
            //int pole = 0;
            //switch (Figura)
            //{
            //    case 1:
            //        Console.Write("Wpisz długość boku a: ");
            //        a = Convert.ToUInt16(Console.ReadLine());
            //        obw = 4 * a;
            //        pole = a * a;
            //        Console.WriteLine($"Obwód: {obw} Pole: {pole}");
            //        break;

            //    case 2:
            //        Console.Write("Wpisz długość boku a: ");
            //        a = Convert.ToInt16(Console.ReadLine());
            //        Console.Write("Wpisz długość boku b: ");
            //        b = Convert.ToInt16(Console.ReadLine());
            //        obw = 2 * a + 2 * b;
            //        pole = a * b;
            //        Console.WriteLine("Obwód: {0} Pole: {1}", obw, pole);
            //        break;

            //    case 3:
            //        Console.Write("Wpisz długość boku a: ");
            //        a = Convert.ToInt16(Console.ReadLine());
            //        Console.Write("Wpisz długość boku b: ");
            //        b = Convert.ToInt16(Console.ReadLine());
            //        Console.Write("Wpisz długość boku c: ");
            //        c = Convert.ToInt16(Console.ReadLine());
            //        Console.Write("Wpisz długość boku h: ");
            //        h = Convert.ToInt16(Console.ReadLine());
            //        obw = a + b + c;
            //        pole = Convert.ToDouble(a * h)/2;
            //        Console.WriteLine("Obwód: {0} Pole: {1}", obw, pole);
            //        break;

            //    case 4:


            //    case 5:


            //    default:
            //        Console.WriteLine("Błąd");
            //        break;
            //}


            Console.WriteLine("Witamy w programie hurtowni XYZ");
            int il_produktow = 0;
            int kod_towaru = 0;
            string nazwa = " ";

            while (il_produktow < 0)
            {


            }

            float wysokosc_kredytu = 0;
            bool decyzja;
            int wiek;
            string status = "";
            float zarobki = 0;
            int hipoteka = 0;
            int zyrant = 0;

            Console.WriteLine("Witamy w banku");
            wysokosc_kredytu += Convert.ToInt16(Console.ReadLine());
            wiek = Convert.ToInt16(Console.ReadLine());
            status = Console.ReadLine();
            zarobki += Convert.ToInt16(Console.ReadLine());
            hipoteka = Convert.ToBoolean(Console.ReadLine());

            
        }
    }
}
