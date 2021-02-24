using System;

namespace Gestione
{
    public class operazioni
    {
        public static void Riempimento(int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
            }
        }
        public static void PariDispari(int[] array)
        {
            int countPari = 0, countDispari = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    countPari++;
                else
                    countDispari++;
            }
            int[] pari = new int[countPari];
            int[] dispari = new int[countDispari];
            int p = 0, d = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    pari[p] = array[i];
                    p++;
                }
                else
                {
                    dispari[d] = array[i];
                    d++;
                }
            }
            Console.WriteLine("l'array pari è:");
            Stampa(pari);
            Console.WriteLine("l'array dispari è:");
            Stampa(dispari);
        }
        public static void Stampa(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array[array.Length - 1]}.");
        }
        public static void BubbleSort1(int[] array)
        {
            int x, y;
            int temp;
            for (x = 0; x < array.Length - x; x++)
            {
                for (y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }
        }
    }
}
