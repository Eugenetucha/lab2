using System;


namespace pupa
{

    internal class Program
    {

        public class Hw1
        {
            public static long QueueTime(int[] costumers, int n)
            {
                int max = 0;
                int[] kassa = new int[n];
                for (int i = 0; i < n; i++)
                {
                    kassa[i] = costumers[i];
                }
                int bape = kassa[0];
                int index = 0;
                int size = kassa.Length;
                if (n == 1)
                {
                    for (int i = 0; i < costumers.Length; i++)
                    {
                        max += costumers[i];
                    }
                }
                else
                {
                    for (int i = 0; i < kassa.Length; i++)
                    {
                        if (bape > kassa[i])
                        {
                            bape = kassa[i];
                            index = i;
                        }
                    
                    }
                    kassa[index] += costumers[size];
                    for (int j = 0; j < n; j++) if (max < kassa[j]) max = kassa[j];   
                }
                return max;
            }
        }

        public static void Main(string[] args)
        {
            long time;
            int[] mas1 = new int[3] { 5, 3, 4 };
            time = Hw1.QueueTime(mas1, 1);
            Console.WriteLine($"{time}");

            int[] mas2 = new int[4] { 10, 2, 3, 3 };
            time = Hw1.QueueTime(mas2, 2);
            Console.WriteLine($"{time}");

            int[] mas3 = new int[3] { 2, 3, 10 };
            time = Hw1.QueueTime(mas3, 2);
            Console.WriteLine($"{time}");
        }
    }
}