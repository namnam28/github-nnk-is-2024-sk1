﻿using System.Security.Authentication.ExtendedProtection;

string again = "a";

    while(again == "a") {
    Console.Clear();
    Console.WriteLine("***********************"); 
    Console.WriteLine("******Generátor náhodných čísel******"); 
    Console.WriteLine("***********************"); 
    Console.WriteLine("*****Ngo Nam Khánh*****"); 
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n; 
    while(!int.TryParse(Console.ReadLine(), out n)) {
        Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných číslo znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní (celé číslo): ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("============================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
    Console.WriteLine("============================================");
    Console.WriteLine();





        // deklarace pole
        int[] myArray = new int[n];

        Random randomNumber = new Random();

        int kladna = 0;
        int zaporna = 0;
        int nuly = 0;

        Console.WriteLine("\n\nNáhodná čísla:");
        for(int i=0; i<n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}; ", myArray[i]);

            if(myArray[i]>0)
                kladna++;
            else if(myArray[i]<0)
                zaporna++;
            else
                nuly++;
        }
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování stiskněte klávesu a");
    again = Console.ReadLine();

}
