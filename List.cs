using System;

class CSharpDasar {
    static void Main(string[] args) {
        //List
        var names = new List<string> {"Game", "Mobil", "Weapon"};
        for (int i = 0; i < names.Count; i++)
        {
            System.Console.Write(names[i] + " ");
        }
    List<int> angka = new List<int>();
    //Menambahkan data pada List
    angka.Add(1);
    angka.Add(2);
    angka.Add(3);
    //Menambahkan sekaligus beberapa data pada List
    angka.AddRange(new int[3] {4,5,6});
    //Menghapus data/ item pada List
    angka.Remove(1);
    //Menghapus data pada List berdasarkan index
    angka.RemoveAt(0);
    //mengetahui index pada suatu data
    angka.IndexOf(3);
    //Mengecek apakah ada data yang sesuai
    System.Console.WriteLine(angka.Contains(10));
    //Mengetahhui panjang suatu List
    System.Console.WriteLine(angka.Count());

    foreach (var a in angka)
    {
        Console.Write(a + " ");
    }
    }
}