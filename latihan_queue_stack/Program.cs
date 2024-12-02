using System;
using System.Collections.Generic;

namespace latihan_queue_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> minimarket = new Queue<string>();

            Console.WriteLine("\nMasukan Jumlah Antrian: ");

            int jumlah_antrian = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < jumlah_antrian; i++)
            {
                Console.Write($"Antrian ke {i + 1}: ");
                minimarket.Enqueue(Console.ReadLine());
            }

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\nJumlah orang dalam antrian: " + minimarket.Count + " orang");
            
            foreach(var orang in minimarket)
            {
                Console.WriteLine("Nama: "+ orang);
            }

            Console.WriteLine("\nData yang sudah selesai antrian");   
            Console.WriteLine("\n-------------------------------");

            for(int a = 0; a < jumlah_antrian; a++)
            {
                Console.WriteLine("\nSisa Antrian: " + minimarket.Count); 
                Console.WriteLine("Atas nama " + minimarket.Dequeue() + " sudah selesai mengantri");
            }    

            if(minimarket.Count == 0)
            {   
                Console.WriteLine("\nAntrian Kosong");
            }

        }
    }
}





        // Queue<string>queue = new Queue<string>();

        // queue.Enqueue("Wiji");
        // queue.Enqueue("Andi");
        // queue.Enqueue("Wahyudi");

        // Console.WriteLine("Isi Queue: ");
        // foreach (string item in queue)
        // {
        //     Console.WriteLine(item);
        // }

        // Console.WriteLine("\nElemen pertama di queue: " + queue.Peek());
        // Console.WriteLine("\nMenghapus elemen: " + queue.Dequeue());
        // Console.WriteLine("\nIsi queue setelah dequeue: ");
        // foreach (string item in queue)
        // {
        //     Console.WriteLine(item);
        // }

    // Stack<int> tumpukan = new Stack<int>();

    // tumpukan.Push(10);
    // tumpukan.Push(30);
    // tumpukan.Push(40);

    // Console.WriteLine("isi stacks: ");
    // foreach(int item in tumpukan)
    // {
    //     Console.WriteLine(item);
    // }
    
    // Console.WriteLine("\nElemen di stack: " + tumpukan.Peek());
    // Console.WriteLine("\nMenghapus Elemen: "+ tumpukan.Pop());
    // Console.WriteLine("Elemen diatas stack sekarang: " + tumpukan.Peek());
