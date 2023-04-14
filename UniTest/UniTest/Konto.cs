using System;

class Konto
{
    static void Main()
    {
        Konto konto1 = new Konto(1, 1000);
        Konto konto2 = new Konto(2, 1500);
        Konto konto3 = new Konto(3, 1700);

        konto1.Auszahlen(500);
        konto2.Einzahlen(10);
        konto3.Auszahlen(222);

        Console.WriteLine($"Kontonummer1: {konto1.Nummer} Betrag1: {konto1.Betrag}");
        Console.WriteLine($"Kontonummer2: {konto2.Nummer} Betrag2: {konto2.Betrag}");
        Console.WriteLine($"Kontonummer3: {konto3.Nummer} Betrag3: {konto3.Betrag}");

        Console.ReadKey();

    }
    public int Nummer { get; private set; }
    public float Betrag { get; private set; }

    public Konto(int nummer, float betrag)
    {
        Nummer = nummer;
        Betrag = betrag;
    }

    public void Einzahlen(float wert)
    {
        if (wert < 0)
        {
            Console.WriteLine("Fehler: Einzahlungsbetrag muss positiv sein.");
        }
        else
        {
            Betrag += wert;
        }
    }

    public void Auszahlen(float wert)
    {
        if (wert < 0)
        {
            Console.WriteLine("Fehler: Auszahlungsbetrag muss positiv sein.");
        }
        else if (wert > Betrag)
        {
            Console.WriteLine("Fehler: Nicht genug Geld auf dem Konto.");
        }
        else
        {
            Betrag -= wert;
        }
    }
}
