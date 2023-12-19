using System;
using System.Collections.Generic;

class Mahasiswa
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public string Jurusan { get; set; }
}

class Program
{
    static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Daftar Mahasiswa");
            Console.WriteLine("3. Update Mahasiswa");
            Console.WriteLine("4. Hapus Mahasiswa");
            Console.WriteLine("5. Keluar");

            Console.Write("Pilih opsi (1-5): ");
            string opsi = Console.ReadLine();

            switch (opsi)
            {
                case "1":
                    TambahMahasiswa();
                    break;
                case "2":
                    TampilkanDaftarMahasiswa();
                    break;
                case "3":
                    UpdateMahasiswa();
                    break;
                case "4":
                    HapusMahasiswa();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opsi tidak valid. Silakan pilih lagi.");
                    break;
            }
        }
    }

    static void TambahMahasiswa()
    {
        Mahasiswa mahasiswaBaru = new Mahasiswa();

        Console.Write("Masukkan Nama Mahasiswa: ");
        mahasiswaBaru.Nama = Console.ReadLine();

        Console.Write("Masukkan Jurusan Mahasiswa: ");
        mahasiswaBaru.Jurusan = Console.ReadLine();

        mahasiswaBaru.Id = daftarMahasiswa.Count + 1;

        daftarMahasiswa.Add(mahasiswaBaru);

        Console.WriteLine("Mahasiswa berhasil ditambahkan.");
    }

    static void TampilkanDaftarMahasiswa()
    {
        if (daftarMahasiswa.Count == 0)
        {
            Console.WriteLine("Belum ada data mahasiswa.");
        }
        else
        {
            Console.WriteLine("Daftar Mahasiswa:");
            foreach (var mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine($"ID: {mahasiswa.Id}, Nama: {mahasiswa.Nama}, Jurusan: {mahasiswa.Jurusan}");
            }
        }
    }

    static void UpdateMahasiswa()
    {
        Console.Write("Masukkan ID Mahasiswa yang akan diupdate: ");
        int idUpdate = Convert.ToInt32(Console.ReadLine());

        Mahasiswa mahasiswaToUpdate = daftarMahasiswa.Find(m => m.Id == idUpdate);

        if (mahasiswaToUpdate != null)
        {
            Console.Write("Masukkan Nama Mahasiswa yang baru: ");
            mahasiswaToUpdate.Nama = Console.ReadLine();

            Console.Write("Masukkan Jurusan Mahasiswa yang baru: ");
            mahasiswaToUpdate.Jurusan = Console.ReadLine();

            Console.WriteLine("Mahasiswa berhasil diupdate.");
        }
        else
        {
            Console.WriteLine("Mahasiswa tidak ditemukan.");
        }
    }

    static void HapusMahasiswa()
    {
        Console.Write("Masukkan ID Mahasiswa yang akan dihapus: ");
        int idHapus = Convert.ToInt32(Console.ReadLine());

        Mahasiswa mahasiswaToDelete = daftarMahasiswa.Find(m => m.Id == idHapus);

        if (mahasiswaToDelete != null)
        {
            daftarMahasiswa.Remove(mahasiswaToDelete);
            Console.WriteLine("Mahasiswa berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Mahasiswa tidak ditemukan.");
        }
    }
}