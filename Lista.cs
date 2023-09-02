using System;
using System.Collections.Generic;


class Lista
{
    
    List<Fordon> fordon = new List<Fordon>();

    public void Skapa()
    {
        Console.WriteLine("Tillverkare: ");
        string tv = Console.ReadLine();
        Console.WriteLine("Modell: ");
        string md = Console.ReadLine();
        Console.WriteLine("År: ");
        int å = int.Parse(Console.ReadLine());

        Fordon Skapa = new Fordon(tv, md, å);
        fordon.Add(Skapa);
    }

    public void SkrivUt()
    {
        foreach(var objekt in fordon){
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Tillverkare: {objekt.GetTillverkare()}");
            Console.WriteLine($"Modell: {objekt.GetModell()}");
            Console.WriteLine($"År: {objekt.GetÅr()}");
            Console.WriteLine("---------------------------------------");
        }
    }
}