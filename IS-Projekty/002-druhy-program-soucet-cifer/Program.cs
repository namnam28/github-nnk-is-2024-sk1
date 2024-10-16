using System;
using System.Data;

class Program {

    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("***Výpis řady čísel****");
            Console.WriteLine("***********************");
            Console.WriteLine("*****Ngo Nam Khánh*****");
            Console.WriteLine("***********************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu" );
            }
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();

         }
     }
 }




