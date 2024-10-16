using System;
using System.Data;

class Program {

    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("***Vykreslování obrazce****");
            Console.WriteLine("***************************");
            Console.WriteLine("*******Ngo Nam Khánh*******");
            Console.WriteLine("***************************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu" );
           }
            
            Console.Write("Zadejte celé číslo ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu" );
            }

            for(int i=1; i <= 10 ; i++); {
                Console.WriteLine(i);
            }

            //int j = 1;
            //while(j <= 10) {
                //Console.WriteLine(j);
                //j++;
            }

            for(int i=1; i<= height; i++) {
                for(int j=1; j<=width; j++) {
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();    
            }

            
            
            
            
            
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
     }
}