using System;

class CSharpDasar {
    static void Main(string[] args) {
      //Break
      for (int i = 0; i < 10; i++)
      {
        System.Console.WriteLine("perulangan ke " + i);

        if (i == 5)
        {
            break;
        }
    
      }
      
      //Continue
      for (int i = 0; i < 10; i++)
      {
        if (int % 2 == 0)
        {
            //Mengabaikan angka genap dan melanjutkan ke iterasi berikutnya
            continue;
        }
        System.Console.WriteLine(i);
      }
    }
}