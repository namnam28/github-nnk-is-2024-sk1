using System;
using System.Dynamic;

class Program {
static void Main() {
        
    string again = "a";
    
        
    while(again=="a") {}
        Console.Clear();
        Console.WriteLine("*************************");
        Console.WriteLine("*****Výpis rady čísel****");
        Console.WriteLine("*************************");
        Console.WriteLine("******Ngo Nam Khánh******");
        Console.WriteLine("*************************");
        Console.WriteLine();

        // Vstup hodnot do programu

        // Vstup hodnot do pragramu - správné řetězy
        int first = int.Parse(Console.ReadLine());
        Console.Write("Zadejte poslední číslo: ")
        int first;
        while(int.TryParse.Console.ReadLine() out first) {
            Console.Write("Nezadali jste první číslo. Zadejte první číslo řady znovu: ");
        }

        Console.Write("Zadejte poslední číslo: ")
        int step;
        while(int.TryParse.Console.ReadLine() out first) {
            Console.Write("Nezadali jste první číslo. Zadejte první číslo řady znovu: ");
        }

         // Výpis řady
         int current = first;
         while(current < last) {
            Console.WriteLine(current);
            current = current + step; // Ruční přičtení diference
         }
         
        Console.WriteLine();
        Console.WriteLine("Zadali jste tyto hodnoty: ");
        Console.WriteLine("První číslo řady: {0}", first);
        Console.WriteLine("Poslední číslo řady: {0}", last);
        Console.WriteLine("Diference: {0}", step);



        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stisknutí klávesy a");
        again = Console.ReadLine();
    } 
}






// toto je jednořádkový komentář 

/* toto je
více řadkový
komentář */






