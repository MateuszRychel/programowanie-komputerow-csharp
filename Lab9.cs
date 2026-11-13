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
