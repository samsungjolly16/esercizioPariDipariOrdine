
using System;
using Gestione;

namespace esercizioPariDipariOrdine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la dimensione dell'array");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            operazioni.Riempimento(array);
            Console.WriteLine("l'array è : ");
            operazioni.Stampa(array);
            operazioni.PariDispari(array);
            operazioni.BubbleSort1(array);
            Console.Write($"l'array ordinato è: ");
            operazioni.Stampa(array);


        }
    }
}
