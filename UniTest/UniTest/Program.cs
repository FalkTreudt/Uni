using System;

class Program
{
    static void Main()
    {
        int n1 = 0, n2 = 1, n3, number = 55;

        Console.Write(n1 + " " + n2 + " ");

        while (n1 + n2 <= number)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }

        Console.ReadKey();
    }
}
