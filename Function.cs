using System;

class CSharpDasar {
    static void Main(string[] args) {
        Tampil();
       
    }

    public static void Tampil()
    {
        System.Console.WriteLine("Game");
    }

    public static void Main (string[] args)
    {
        int hasil = Return();
        System.Console.WriteLine(hasil);
    }

    public static int Return()
    {
        return 5;
    }

    public static void Main (string[] args)
    {
        int hasil = Counter(10);
        System.Console.WriteLine(hasil);
    }

    public static int Counter(int damage)
    {
        return damage + 5;
    }
}