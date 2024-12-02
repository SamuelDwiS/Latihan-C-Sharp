using System;

namespace latihan_array
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] angka ={10 , 20 , 30 , 5 , 25};
        int max = angka[0];
        int min = angka[0];

        foreach(int num in angka)
        {
            if(num > max) max = num;
            if(num < min) min = num;
        }

        Console.WriteLine("Nilai maksimum: " + max);
        Console.WriteLine("Nilai minimum: " + min);


// int[] nilaiUjian = { 75 , 90 , 85 , 60 , 80 };
// int total = 0;
// double rataRata;

// foreach(int nilai in nilaiUjian)
// {
//     total += nilai;
// }

// rataRata = (double)total / nilaiUjian.Length;

// Console.WriteLine("Nilai rata-rata: " + rataRata);

// Console.WriteLine("Nilai di atas rata-rata: ");

// foreach(int nilai in nilaiUjian)
// {
//     if(nilai > rataRata)
//     {
//         Console.WriteLine(nilai);
//     }


// int [] angka = {20,35,60,80,98,78,67};
// int pembanding = 40;
// int jumlah = 0;

// foreach(int a in angka)
// {
//     if (a > pembanding)
//     {
//         jumlah++;
//     }
// }
//         Console.WriteLine("angka asli : " + string.Join(",", angka));

// Array.Reverse(angka);
// Console.WriteLine("angka terbalik : " + string.Join(",", angka));
// Console.WriteLine("Jumlah angka yang lebih besar dari 40: " + jumlah);

// int [] angka = {20,35,60,80,98,78,67};
// int pembanding = 40;
// int jumlah = 0;

// foreach(int a in angka)
// {
//     if (a > pembanding)
//     {
//         jumlah++;
//         Console.WriteLine(a);
//     }
// }
// Console.WriteLine("Jumlah angka yang lebih besar dari 40: " + jumlah);

        }
    }
}
