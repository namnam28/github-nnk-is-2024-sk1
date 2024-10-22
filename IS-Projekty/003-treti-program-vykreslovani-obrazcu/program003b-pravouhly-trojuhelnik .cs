using System.Globalization;

string again = "a";

    while(again == "a") {
        Console.Clear();
        Console.WriteLine("******************************"); 
        Console.WriteLine("****Pravoúhlý trojúhelník*****"); 
        Console.WriteLine("******************************"); 
        Console.WriteLine("********Ngo Nam Khánh*********"); 
        Console.WriteLine("******************************"); 
        Console.WriteLine();

        Console.Write("Zadejte výšku obrazce (celé číslo): ");
        int height;
        while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku: ");
        }

        for(int i=1; i<= height; i++) {
            for(int j=1; j<= height; j++) {
                Console.Write("* ");

                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu A");
        again = Console.ReadLine();
    }

