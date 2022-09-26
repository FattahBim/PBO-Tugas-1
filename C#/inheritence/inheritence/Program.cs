using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program inheritence Bangun Datar Dan Luas");
            Console.WriteLine();
            Console.WriteLine("Pilihan Menu:");
            Console.WriteLine("A. Persegi");
            Console.WriteLine("B. Lingkaran");
            Console.WriteLine("C. Persegi Panjang");
            Console.WriteLine("D. Segitiga");

            Console.WriteLine();

            BangunDatar bandat = new BangunDatar();

            Persegi H = new Persegi();
            H.sisi = 2;

            Lingkaran I = new Lingkaran();
            I.jarijari = 22;

            PersegiPanjang J = new PersegiPanjang();
            J.Panjang = 8;
            J.lebar = 4;
            Segitiga K = new Segitiga();
            K.alas = 12;
            K.tinggi = 8;
            bandat.luas();
            bandat.keliling();
            H.luas();
            H.keliling();
            I.luas();
            I.keliling();
            J.luas();
            J.keliling();
            K.luas();
            K.keliling();
        }
        public class BangunDatar
        {
            internal float luas()
            {
                Console.WriteLine("Menghitung luas pada bangun datar");
                return 0;
            }
            internal float keliling()
            {
                Console.WriteLine("Menghitung keliling pada bangun datar");
                return 0;
            }
        }
        public class Persegi : BangunDatar
        {
            private double s;
            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
        }
        public class Lingkaran : BangunDatar
        {
            private double r;
            public double jarijari
            {
                get { return r; }
                set
                {
                    r = value;
                }
            }
        }
        public class PersegiPanjang : BangunDatar
        {
            private float P,L;

            public float Panjang
            {
                get { return P; }
                set
                {
                    P = value;
                }
            }

            public float lebar
            {
                get { return L; }
                set
                {
                    L = value;
                }
            }
        }
        public class Segitiga : BangunDatar
        {
            private float A, T;

            public float alas
            {
                get { return A; }
                set
                {
                    A = value;
                }
            }
            public float tinggi
            {
                get { return T; }
                set
                {
                    T = value;
                }
            }
        }
    }
}