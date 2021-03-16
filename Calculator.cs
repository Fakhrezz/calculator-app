using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 10; // deklarasi variabel a, dg nilai 10
            // int b = 6; // deklarasi variabel b, dg niai 6

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Pilih menu 1 - 4 = ");
            int menu = int.Parse(Console.ReadLine());
            if (menu > 4)
            {
                Console.WriteLine("Menu Tidak Ditemukan");
            }
            else
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());


                //Console.Write("Inputkan nilai a = ");
                //int a = int.Parse (Console.ReadLine()); // proses casting

                //Console.Write("Inputkan nilai b = ");
                //int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                //Console.WriteLine(); // tambahkan baris kosong

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Hasil Penggurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                        break;
                }
                Console.WriteLine("\nTekan sembararang key untuk keluar");
                Console.ReadKey();
            }
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
