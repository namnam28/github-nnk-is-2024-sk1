using System;
using System.Data;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear() ;
            Console.WriteLine("***********************");
            Console.WriteLine("***Výpis řady čísel****");
            Console.WriteLine("***********************");
            Console.WriteLine("*****Ngo Nam Khánh*****");
            Console.WriteLine("***********************");
            Console.WriteLine();



            Console.Write("Zadejte první číslo (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }

             Console.Write("Zadejte poslední číslo (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }


            Console.Write("Zadejte diferenci (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }

           Console.WriteLine();
           Console.WriteLine("==================");
           Console.WriteLine("Výpis číselné řady");
           int current = first;
           while(current <= last) {
                Console.WriteLine(current);
                current = current + step;
           }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}

