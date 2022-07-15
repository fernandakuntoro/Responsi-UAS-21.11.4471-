using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            int Nim;
            string Nama;
            string JenisKelamin;
            double ipk;
            Console.Write("Tambah data Mahasiswa");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("NIM : ");
            Nim = int.Parse(Console.ReadLine());
            Console.Write("Nama : ");
            Nama = (Console.ReadLine());
            Console.Write("Jenis Kelamin [L/P] : ");
            JenisKelamin = (Console.ReadLine());
            if (JenisKelamin == "L")
            {
                JenisKelamin = "Laki-Laki";
            }
            else if (JenisKelamin == "P")
            {
                JenisKelamin = "Perempuan";
            }
            Console.Write("IPK : ");
            ipk = double.Parse(Console.ReadLine());

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
