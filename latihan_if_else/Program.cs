using System;

namespace latihan_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
        int usia = Convert.ToInt32(Console.ReadLine());
        if (usia >=18 && usia <=35){
            Console.WriteLine("Dewasa Muda");
        } else if (usia >=36 && usia <=60){
            Console.WriteLine("Dewasa Tua");
        } else if (usia > 60){
            Console.WriteLine("Lansia");
        } else if (usia < 18){
            Console.WriteLine("Anak-anak");
        }
        
            // Random random = new Random();
            // bool cobaLagi = true;
            // int min = 1;
            // int max = 100;
            // int tebak;
            // int angka;
            // int tebakan;
            // while (cobaLagi)
            // {
            //     tebak = 0;
            //     tebakan = 0;
            //     angka = random.Next(min, max + 1);

            //     while(tebak != angka)
            //     {
            //         Console.WriteLine("Tebak satu angka " + min + " - " + max + " : ");
            //         tebak = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Tebak: " + tebak);

            //         if( tebak > angka)
            //         {
            //              Console.WriteLine(tebak + " Angka terlalu tinggi");   
            //         }
            //         else if( tebak < angka)
            //         {
            //             Console.WriteLine(tebak + " Angka terlalu rendah"); 
            //         }
            //         tebakan++;
            //     }
            //     Console.WriteLine("Angka: " + angka);
            //     Console.WriteLine("Anda benar");
            //     Console.WriteLine("Tebakan berapa kali: " + tebakan);

            //     if(tebak == angka)
            //     {
            //         break;
            //     }
            // }


        }
    }
}
