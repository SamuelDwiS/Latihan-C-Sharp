using System;

namespace aritmatika
{
    class Program
    {
        static void Main(string[] args)
        {
          
        //   Random random = new Random();
        //     bool cobaLagi = true;
        //     int min = 1;
        //     int max = 100;
        //     int tebak;
        //     int angka;
        //     int tebakan;

        //     while (cobaLagi)
        //     {
        //         tebak = 0;
        //         tebakan = 0;
        //         angka = random.Next(min, max + 1);

        //         while(tebak != angka)
        //         {
        //             Console.WriteLine("Tebak satu angka " + min + " - " + max + " : ");
        //             tebak = Convert.ToInt32(Console.ReadLine());
        //             Console.WriteLine("Tebak: " + tebak);

        //             if( tebak > angka)
        //             {
        //                  Console.WriteLine(tebak + " Angka terlalu tinggi");   
        //             }
        //             else if( tebak < angka)
        //             {
        //                 Console.WriteLine(tebak + " Angka terlalu rendah"); 
        //             }
        //             tebakan++;
        //         }
        //         Console.WriteLine("Angka: " + angka);
        //         Console.WriteLine("Anda benar");
        //         Console.WriteLine("Tebakan berapa kali: " + tebakan);

        //         if(tebak == angka)
        //         {
        //             break;
        //         }
        //     }

// int[] angka ={10 , 20 , 30 , 5 , 25};
// int max = angka[0];
// int min = angka[0];

// foreach(int num in angka)
// {
//     if(num > max) max = num;
//     if(num < min) min = num;

// }

// Console.WriteLine("Nilai maksimum: " + max);
// Console.WriteLine("Nilai minimum: " + min);

int[] nilaiUjian = { 75 , 90 , 85 , 60 , 80 };
int total = 0;
double rataRata;

foreach(int nilai in nilaiUjian)
{
    total += nilai;
}

rataRata = (double)total / nilaiUjian.Length;

Console.WriteLine("Nilai rata-rata: " + rataRata);

Console.WriteLine("Nilai di atas rata-rata: ");

foreach(int nilai in nilaiUjian)
{
    if(nilai > rataRata)
    {
        Console.WriteLine(nilai);
    }
}




        }
    }
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

        // static double HitungLuasLingkaran(double jarijari)
        // {
        //     return Math.PI*jarijari*jarijari; // MENGEMBALIKAN LUAS
        // }

        // static double HitungLuasPersegiPanjang (double Panjang, double Lebar)
        // {
        //     return Panjang*Lebar;
        // }

        // static void TampilkanPesanSelamat()
        // {
        //     Console.WriteLine("Selamat Datang Bro");
        // }

        // static double HitungLuasSegitiga(double alas, double tinggi)
        // {
        //     return 0.5 * alas * tinggi;
        // }
        // static void Main(string[] args)
        // {
        //     double jarijari= 5.0;
        //     double Panjang = 10.0;
        //     double Lebar = 5.0;
        //     double alas = 15.0;
        //     double tinggi = 25.0;
        //     int ulang = 10;

        //     for(int i=1; i<ulang;i++){
        //         TampilkanPesanSelamat();
        //     }
        //     double luas = HitungLuasLingkaran(jarijari); // MEMANGGIL FUNGSI
        //     double LuasPesegiPanjang = HitungLuasPersegiPanjang(Panjang,Lebar);
        //     double LuasSegitiga= HitungLuasSegitiga(alas,tinggi);

        //     Console.WriteLine("Luas lingkaran dengan jari-jari "+jarijari+ " adalah: "+luas);
        //     Console.WriteLine("Luas Persegi Panjang: " +LuasPesegiPanjang);
        //     Console.WriteLine("Luas Segitiga: " +LuasSegitiga);

            // int alas = 25;
            // int tinggi = 15;

            // int luas = alas * tinggi / 2;
            
            // Console.WriteLine ("Hasil Luas segitiga: " + luas);

            // string nama = Console.ReadLine(); 
            // int umur = Convert.ToInt32(Console.ReadLine());
            // string kota_asal = "Surakarta";
            // string no_hp = "089665465474";

            // Console.WriteLine ("Nama saya " + nama + " saya berumur " + umur + " dan saya berasal dari kota " + kota_asal + "Kalian bisa menghubungi saya di no "+ no_hp);

            // int nilai_mtk = Convert.ToInt32(Console.ReadLine());

            // if(nilai_mtk >= 76){
            //     Console.WriteLine("Diatas KKM");
            // } else {
            //     Console.WriteLine("Dibawah KKM");
            // }


        // int usia = Convert.ToInt32(Console.ReadLine());

        // if (usia >=18 && usia <=35){
        //     Console.WriteLine("Dewasa Muda");
        // } else if (usia >=36 && usia <=60){
        //     Console.WriteLine("Dewasa Tua");
        // } else if (usia > 60){
        //     Console.WriteLine("Lansia");
        // } else if (usia < 18){
        //     Console.WriteLine("Anak-anak");
        // }

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

        // int angka;

        // do {
        //     Console.WriteLine("Masukkan angka lebih besar dari 10:  ");
        //     angka = Convert.ToInt32(Console.ReadLine());
        // } while (angka <= 10);

        // Console.WriteLine("Anda memasukkan angka:  " + angka);

    // for (int a = 1; a <=20; a++)
    // {
    //     if (a % 2 == 0)
    //     {
    //         Console.WriteLine(a + "Bilangan Genap");
    //     } 
    //     else 
    //     {
    //         Console.WriteLine(a+"Bilangan ganjil"):
    //     }
    // }

        // int i = 1;
        // int total = 0;

        // while ( i <= 100) {
        //     total += i;
        //     i++;
        // }
        // Console.WriteLine("Total penjumlahan dari 1 sampai 100 adalah: " + total);

        // int angka;
        // do {
        //     Console.WriteLine("Masukkan angka negatif:  ");
        //     angka = int.Parse(Console.ReadLine());
        // } while (angka >=0);

        // Console.WriteLine("Angka Negatif");
   
    // int a = Convert.ToInt32(Console.ReadLine());
        // switch(a){
        //     case 1:
        //     Console.WriteLine("Senin");
        //     break;
        //     case 2:
        //     Console.WriteLine("Selasa");
        //     break;
        //     case 3:
        //     Console.WriteLine("Rabu");
        //     break;
        //     case 4:
        //     Console.WriteLine("Kamis");
        //     break;
        //     case 5:
        //     Console.WriteLine("Jumat");
        //     break;
        //     case 6:
        //     Console.WriteLine("Sabtu");
        //     break;
        //     case 7:
        //     Console.WriteLine("Minggu");
        //     break;
        // default:
        // Console.WriteLine("Angka tidak valid");
        // break;
        // }
