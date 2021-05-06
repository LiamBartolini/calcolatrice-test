using System;

namespace AS2021_4H_TPSIT_BartoliniLiam_Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcolatrice - Bartolini Liam - 06/05/2021");
            
            Calcolatrice c = new();
            double res = c.Operazione(2, "+", 3);
            Console.WriteLine($"Il risultato di 2 + 3 è: { res }");

            res = c.Operazione(2, "*", 4);
            Console.WriteLine($"Il risultato di 2 * 3 è: { res }");
        }
    }

    /// <summary>
    /// Classe per gestire "operazioni" da calcolatrice
    /// </summary>
    public class Calcolatrice
    {
        public double Operazione(double operando1, string operatore, double operando2)
        {
            double res = 0;
            switch (operatore)
            {
                case "+":
                    res = operando1 + operando2;
                    break;

                case "*":
                    res = operando1 * operando2;
                    break;
            }
            return res;
        }
    }
}