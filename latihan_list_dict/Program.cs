using System;

namespace latihan_list_dict
{
    class Program
    {
        static void Main(string[] args)
        {

        List<int> bilangan = new List<int>();
        Console.WriteLine("Masukan 10 angka :" );
  
        for(int i = 0; i < 10; i++)
        {
            Console.Write($"Bilangan ke-{i + 1}: ");
            bilangan.Add(Convert.ToInt32(Console.ReadLine()));
        }

            Console.WriteLine("Daftar Bilangan : ");
        foreach (var number in bilangan)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nBilangan Ganjil: ");
        foreach(var number in bilangan)
        {
            if( number % 2 != 0)
            {
                Console.WriteLine( number + " Bilangan Ganjil");
            }
         }

// Dictionary<string, int> Barang = new Dictionary<string, int>();

    // Console.WriteLine("Masukan Data Barang ");
    // for (int a = 0; a < 4; a++)
    // {
    //     Console.WriteLine("\nMasukan Nama Barang: ");
    //     string namaBarang = Console.ReadLine();

    //     Console.WriteLine("Masukan Harga Barang: ");
    //     int hargaBarang = Convert.ToInt32(Console.ReadLine());

    //     Barang[namaBarang] = hargaBarang;
    // }
    // Console.WriteLine("\nDAFTAR BELANJA");
    // Console.WriteLine("----------------");

    // foreach(KeyValuePair<string, int> pair in Barang)
    // {
    //     Console.WriteLine("\nNama Barang = " + pair.Key + " || Harga = " + pair.Value);
    // } 

       
        }
    }
}
