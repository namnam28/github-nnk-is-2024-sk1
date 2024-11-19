﻿﻿using System.Security.Authentication.ExtendedProtection;

string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("****** Generátor pseudonáhodných čísel *****");
            Console.WriteLine("********************************************");
            Console.WriteLine("************** Ngo Nam Khánh ***************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            int myCompare = 0;
            int myChange = 0;
            myCompare++;
            myChange++;

            myStopwatch.Start();
            for(int i =0; i < n-1; i++) {
                
                for(int j = 0; j < n-i-1; j++) {
                    myCompare++;
                    if(myArray[j] > myArray[j+1]) {
                        int tmp = myArray[j+1];
                        myArray[j+1] = myArray[j];
                        myArray[j] = tmp;
                        myChange++;
                    }
                }
            }

            Console.WriteLine("\n\n\nSeřazené pole");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]);
            }    

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            

            Console.WriteLine();
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }