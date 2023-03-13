// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    public static string[] _angka = { "nol", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas", "belas", "puluh" };

    public static string[] _simbol = { "tambah", "+", "kurangi", "-", "kali", "*", "bagi", "/" };

    static void Main()
    {
        string ulang = "";
        do
        {
            Console.WriteLine("Selamat Datang di Program Perhitungan");
            Console.Write("Contoh : satu tambah satu ");
            Console.Write("\nOperator : tambah, kali, kurangi, bagi");
            Console.Write("\nInput perhitungan : ");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');

            int num1 = 0, num2 = 0;
            char symbol = ' ';

            for (int i = 0; i < _angka.Length; i++)
            {
                if (inputArray[0] == _angka[i])
                {
                    num1 = i;
                    break;
                }
            }

            for (int i = 0; i < _simbol.Length; i++)
            {
                if (inputArray[1] == _simbol[i]) { symbol = Convert.ToChar(_simbol[i + 1]); break; }
            }

            for (int i = 0; i < _angka.Length; i++)
            {
                if (inputArray[2] == _angka[i])
                {
                    num2 = i;
                    break;
                };
            }

            perhitungan(num1, symbol, num2);

            Console.Write("Apakah anda ingin melanjutkan? (ya/tidak) ");
            ulang = Console.ReadLine();

        } while (ulang == "ya");
        Console.WriteLine("Terimakasih telah melakukan program perhitungan ini \n\t\tHave a nice day!!");
    }

    static void perhitungan(int num1, char symbol, int num2)
    {
        int hasil = 0;
        switch (symbol)
        {
            case '+':
                hasil = num1 + num2;
                break;
            case '-':
                hasil = num1 - num2;
                break;
            case '*':
                hasil = num1 * num2;
                break;
            case '/':
                hasil = num1 / num2;
                break;
        }

        if (hasil >= 0 && hasil < 12)
        {
            Console.WriteLine($"Hasil : {_angka[hasil]}");
        }
        else if (hasil >= 12 && hasil < 20)
        {
            hasil -= 10;
            Console.WriteLine($"Hasil : {_angka[hasil]} {_angka[12]}");
        }
        else if (hasil < 0)
        {
            if (hasil < -12)
            {
                hasil *= -1;
                Console.WriteLine($"Hasil : negatif {_angka[hasil]} {_angka[12]}");
            }
            else
            {
                hasil *= -1;
                Console.WriteLine($"Hasil : negatif {_angka[hasil]}");
            }
        }
        else
        {
            Console.WriteLine($"Hasil : {hasil}");
        }
    }
}
