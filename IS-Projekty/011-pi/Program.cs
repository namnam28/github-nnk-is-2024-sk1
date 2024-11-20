using System;
class Program
{
    static void Main()
    {
        // Počet iterací pro výpočet
        int iterations = 3000;  
        
        double pi = CalculatePi(iterations);

        Console.WriteLine($"Hodnota π po {iterations} iteracích: {pi}");
    }

    static double CalculatePi(int iterations)
    {
        double pi = 3.0;
        
        for (int n = 1; n <= iterations; n++)
        {
            // Nilakanthova řada
            double term = 4.0 / ((4 * n) * (4 * n + 1) * (4 * n + 2));
            if (n % 2 == 1)
            {
                pi -= term;  // Sudé členy řady (sčítání)
            }
            else
            {
                pi += term;  // Liché členy řady (odčítání)
            }
        }

        return pi;
    }
}