using System;

namespace hackerrank_staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Basamak Sayısını Giriniz");
            int step = int.Parse(Console.ReadLine());
             for(int i=0; i<step;i++) {
                for(int x= step-1; x>i;x--)
                {
                    Console.Write(" ");
                }
                for(int y=0;y <=i;y++) {
                    Console.Write("#");
                }
                Console.WriteLine();
             }
        }
    }
}
