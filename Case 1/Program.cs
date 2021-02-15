using System;
using System.Text.RegularExpressions;

namespace Case_1
{
    class Program
    {
        const int MaxLength = 100;

        static void Main(string[] args)
        {

            string pesan = "maafAkuenggak";

            ValidasiPesan(pesan);

            Console.ReadLine();
        }

        public static void ValidasiPesan(string pesan)
        {
            Regex r = new Regex("^[a-zA-Z ]+$");
            if (r.IsMatch(pesan) && pesan.Length <= MaxLength)
            {
                pesan_rahasia(pesan);
            }
            else if (pesan.Length > MaxLength)
            {
                Console.WriteLine("Pesan terlalu panjang");
            }
            else
            {
                Console.WriteLine("Pesan harus huruf tidak boleh mengandung angka dan simbol");
            }
                
        }

        static void pesan_rahasia(string pesan)
        {
            int x = 0;
            int sisa;
            int N = pesan.Length / 3;
            char[,] indexChar = new char[N, N];

            sisa = indexChar.Length - pesan.Length;

            if (sisa != 0)
            {
                for (int i = 0; i < sisa; i++)
                {
                    pesan = pesan + '*';
                }
            }

            char[] data = pesan.ToCharArray();

            Console.WriteLine("Input");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    indexChar[i, j] = data[x];
                    x += 1;

                    Console.Write(indexChar[i, j] + " ");
                }
                
                Console.WriteLine();
            }

            //rotasi 90 ke searah jarum jam
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = i; j < N - i - 1; j++)
                {
                    char temp = indexChar[i, j];
                    indexChar[i, j] = indexChar[N - 1 - j, i];
                    indexChar[N - 1 - j, i] = indexChar[N - 1 - i, N - 1 - j];
                    indexChar[N - 1 - i, N - 1 - j] = indexChar[j, N - 1 - i];
                    indexChar[j, N - 1 - i] = temp;
                }
            }

            //print hasil rotasi
            Console.WriteLine("output");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (indexChar[i,j] != '*')
                    {
                        Console.Write(indexChar[i, j]);
                    }
                }
            }

        }
    }
}
