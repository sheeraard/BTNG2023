using System;

class CSharpDasar {
    static void Main(string[] args) {
        //If
        int i = 5;
        if (10 > i)
        {
            System.Console.WriteLine("Benar!");
        }

        //Else
        int i = 5;
        if (1 > i)
        {
            System.Console.WriteLine("Benar!");
        }
        else{
            System.Console.WriteLine("Salah!");
        }

        //Else If
        int nilai =75;
        if (nilai >=90)
        {
            System.Console.WriteLine("Anda mendapatkan A.");
        }
        else if (nilai >= 80)
        {
            System.Console.WriteLine("Anda mendapatkan B.");
        }
        else if (nilai >= 70)
        {
            System.Console.WriteLine("Anda mendapatkan C.");
        }
        else
        {
            System.Console.WriteLine("Anda mendapatkan D atau E.");
        }

        //Switch
        int nilai = 75;
        switch(nilai)
        {
            case > 95:
            System.Console.WriteLine("Memuaskan");
            break;
            case > 80:
            System.Console.WriteLine("Baik");
            break;
            case >= 75:
            break;
            default:
            System.Console.WriteLine("Kurang");
            break;
        }
    }
}