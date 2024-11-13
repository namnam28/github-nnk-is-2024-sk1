class Program {
    static void Main() {
                Console.WriteLine("\nZadejte váš text: ");
        string myText = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(myText);
        Console.WriteLine(myText[0]);
        Console.WriteLine(myText.Length);

        string samohlasky = "aáeéěiíoóuůúyý";
        string souhlasky = "bcčdfghjklmnpqrstuvwxz";
        string cislice = "0123456789";

        int pocetSamohlasek = 0;
        int pocetSouhlasek = 0;
        int pocetCislic = 0;
        int pocetOstatnich = 0;

         foreach(char znak in myText) {
                if(souhlasky.Contains(znak)) {
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)) {
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(znak)) {
                    pocetCislic++;
                }
                else
                    pocetOstatnich++;
            }

            Console.WriteLine();
            Console.WriteLine("Počet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Počet číslic: {0}", pocetCislic);
            Console.WriteLine("Počet ostatních zanků: {0}", pocetOstatnich);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
                }
            }
}