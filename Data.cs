using System;

class CSharpDasar {
    static void Main(string[] args) {
        // Number
        int angka = 10;
        double angkaDouble = 3.14;
        float angkaFloat = 10.2f;

        Console.WriteLine(angka);
        Console.WriteLine(angkaDouble);
        Console.WriteLine(angkaFloat);

        // String
        string firstName;
        string lastName = "Game";

        firstName = "Divisi";

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        firstName += lastName;

        Console.WriteLine(firstName);

        // Backslash
        string hari = "senin \tselasa \trabu \tkamis";
        string bulan = "januari \rfebruari \rmaret \r";
        string film = "\"One Piece\"";

        Console.WriteLine(hari);
        Console.WriteLine(bulan);
        Console.WriteLine(film);

        //Manipulasi String

        Console.WriteLine(txt.ToLower());
        Console.WriteLine(txt.ToUpper());
        Console.WriteLine("Panjang string tersebut adalah" + txt.Length);
        Console.WriteLine(txt + " Yang di Gabungkan");

        //String Interpolation
        string name = "Aufa";
        var date = DateTime.Now;
        //String Interpolation
        Console.WriteLine($"Halo, {name}! hari ini adalah {date.DayOfWeek}, pukul {date:HH:mm} WIB.")

        //Boolean
        bool benar  true;
        bool salah = false;

        if (benar==true)
        {
            Console.WriteLine("Ini adalah pernyataan benar.");
        }
        else
        {
            Console.WriteLine("Ini adalah pernyataan salah");
        }

        //Float ke Int
        float first =3.14f;
        int second = (int)first;

        Console.WriteLine(second);

        //Number ke String
        int angkaSatu = 10;
        float angkaDua = 20.7f;

        Console.WriteLine($"{angkaSatu.ToString()}{angkaDua.ToString()}");

        //String ke Int
        string pertama = "5";
        string kedua = "7";
        int sum = int.Parse(pertama) + int.Parse(kedua);
        Console.WriteLine(sum);
        
    }
}
