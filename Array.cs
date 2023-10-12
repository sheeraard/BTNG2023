using System;

class CSharpDasar {
    static void Main(string[] args) {
        //Array
        string[] divisi = {"web", "mobile", "game", "mulmed", "jaringan"};
        System.Console.WriteLine(divisi[0]);
        System.Console.WriteLine(divisi[1]);
        System.Console.WriteLine(divisi[2]);
        System.Console.WriteLine(divisi[3]);
        System.Console.WriteLine(divisi[4]);

        string[] names = new string[5];
        names[0] = "web";
        names[1] = "mobile";
        names[2] = "game";
        names[3] = "mulmed";
        names[4] = "jaringan";

        //Array 2D
        int[,] number = new int[2,3];
        int[,] numbers = {{1,2,3},{4,5,6}};
        System.Console.WriteLine(numbers[0,1]);//Output 2
        System.Console.WriteLine(numbers[1,2]);//Output 6

        //Array 3D
        int[,,] number  new int[2,2,3];
        int[,,] numbers = {{1,2,3},{4,5,6},{{7,8,9},{10,11,12}}};
        System.Console.WriteLine(numbers[0,0,0]);
        System.Console.WriteLine(numbers[1,1,0]);
    }
}