using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            int hasil;
            int a, b;

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            
            Console.WriteLine();
            Console.Write("Input nomor menu [1 2 3 4] : ");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine();
            

            switch (code)
            {
                case 1:
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    hasil = a + b;
                    Console.WriteLine();
                    Console.WriteLine("Hasil penambahan "+a+ " + " +b+ " = "+hasil);
                    break;
                case 2:
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    hasil = a - b;
                    Console.WriteLine();
                    Console.WriteLine("Hasil pengurangan " + a + " - " + b + " = " + hasil);
                    break;
                case 3:
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    hasil = a * b;
                    Console.WriteLine();
                    Console.WriteLine("Hasil perkalian " + a + " x " + b + " = " + hasil);
                    break;
                case 4:
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    hasil = a / b;
                    Console.WriteLine();
                    Console.WriteLine("Hasil pembagian " + a + " : " + b + " = " + hasil);
                    break;
                default:
                    Console.WriteLine("Maaf menu yang Anda pilih tidak tersedia");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Tekan sembarang untuk keluar");
            Console.ReadKey();
        }
    }
}

          
        

