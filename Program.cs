using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int val = 1; 
        Lista f = new Lista();
        while(val != 0){
        
        Console.WriteLine("=====MENY=====");
        Console.WriteLine("1. Lägg till Fordon");
        Console.WriteLine("2. Skriv ut Fordon"); 
        Console.WriteLine("0. Avsluta programmet"); 

        val = int.Parse(Console.ReadLine());
        if(val == 1){
            f.Skapa();
        }

        else if(val == 2){
            f.SkrivUt();
        }

        }
    }
}