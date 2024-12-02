using System;

namespace latihan_perulangan
{
    class Program
    {
        static void Main(string[] args)
        {
        int i = 1;
        int total = 0;

        while ( i <= 100) {
            total += i;
            i++;
        }
        Console.WriteLine("Total penjumlahan dari 1 sampai 100 adalah: " + total);

        int angka;
        do {
            Console.WriteLine("Masukkan angka negatif:  ");
            angka = int.Parse(Console.ReadLine());
        } while (angka >=0);
        Console.WriteLine("Angka Negatif");


        for (int a = 1; a <=20; a++)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(a + "Bilangan Genap");
            } 
            else 
            {
                Console.WriteLine(a+"Bilangan ganjil"):
            }
        }







        // for (int i = 1; i <= 5; i++) {
        //     Console.WriteLine("Perulangan ke -" + i);
        // }

        // int i = 1;
        // while (i <= 5 ) {
        //     Console.WriteLine("Perulangan ke -" + i);
        //     i++;
        // }
        
        // int i = 1;
        // do {
        //     Console.WriteLine("Perulangan ke - " + i);
        //     i++;
        // } while (i <= 5);

        // int i = 1;
        // int total = 0;

        // while ( i <= 5) {
        //     total += i;
        //     i++;
        // }
        // Console.WriteLine("Total penjumlahan dari 1 sampai 5 adalah: " + total);






            }
        }
    }
}
