using System;

class CSharpDasar {
    static void Main(string[] args) {
        //Perulangan For
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Perulangan ke " +);
        }
        

        //While
        int i = 0;
        while (i < 5)
        {
            System.Console.WriteLine("perulangan ke" + i);
            i++;
        }

        //Do While
        int i = 5;
        do
        {
            System.Console.WriteLine("Perulangan ke" + i);
            i++;
        } while (i < 5);

        //For Each
        int i = 0;
        int[] angka = new int[5] {1, 2, 3, 4, 5};
        foreach (int a in angka)
        {
            System.Console.WriteLine("Ini adalah isi array urut dari indeks ke " + i++ "yaitu" +a);
        }
    }
}