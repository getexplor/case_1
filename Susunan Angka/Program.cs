using System;

namespace Susunan_Angka
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka;
            angka = 4;

            susunAngka(angka);
            Console.ReadLine();
        }

        public static void susunAngka(int angka)
        {
            int jumlah, temp;
            temp = angka;
            int xangka = angka / 2;
            jumlah = angka;


            while (temp != 0)
            {
                Console.Write(temp + ",");
                if (temp == jumlah)
                {
                    temp--;
                }
                else
                {
                    int current = temp;

                    do
                    {
                        if (xangka + current > jumlah)
                        {
                            xangka--;
                        }
                        else
                        {
                            Console.Write(xangka + ",");
                            current += xangka;
                        }
                    } while (current != jumlah);

                    if (xangka == 1)
                    {
                        temp--;
                        xangka = jumlah / 2;
                    }
                    else
                    {
                        xangka--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
