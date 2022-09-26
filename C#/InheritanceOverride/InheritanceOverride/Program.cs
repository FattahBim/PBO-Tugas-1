using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();     
            Console.ReadLine();
        }
    }
    class Menu
    {
        public void menu()
        {
            Console.WriteLine("Program Inheritance Override Luas dan bangun datar");
            Console.WriteLine();
            Console.WriteLine("Pilihan Menu Inheritance Override:");
            Console.WriteLine("A. Persegi");
            Console.WriteLine("B. Lingkaran");
            Console.WriteLine("C. Persegi Panjang");
            Console.WriteLine("D. Segitiga");

            Console.WriteLine();

            Persegi a = new Persegi();

            Console.WriteLine("A. Menghitung Persegi");
            Console.WriteLine();
            Console.Write("Masukan Sisi : ");
            a.sisi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas = {0} cm", a.hitungLuas());
            Console.WriteLine("Keliling = {0} cm", a.hitungKeliling());
            Console.WriteLine();

            Lingkaran d = new Lingkaran();

            Console.WriteLine("B. Menghitung Lingkaran");
            Console.WriteLine();
            Console.Write("Maasukan Jari-Jari : ");
            d.jarijari = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas       = {0} cm", d.hitungLuas());
            Console.WriteLine("Keliling   = {0} cm", d.hitungKeliling());
            Console.WriteLine();

            PersegiPanjang b = new PersegiPanjang();

            Console.WriteLine("C. Menghitung Persegi Panjang");
            Console.WriteLine();
            Console.Write("Masukan Panjang : ");
            b.panjang = (int.Parse(Console.ReadLine()));
            Console.Write("Lebar   : ");
            b.lebar = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas    = {0} cm", b.hitungLuas());
            Console.WriteLine("Keliling   = {0} cm", b.hitungKeliling());
            Console.WriteLine();

            Segitiga c = new Segitiga();

            Console.WriteLine("D. Menghitung Segitiga");
            Console.WriteLine();
            Console.Write("Masukan Alas   : ");
            c.alas = (int.Parse(Console.ReadLine()));
            Console.Write("Masukan Tinggi : ");
            c.tinggi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas   = {0} cm", c.luas_segitiga());
        }

    }

    public abstract class BangunDatar
    {
        public double _hitung;

        public double Hitung
        {
            get { return _hitung; }
            set { _hitung = value; }
        }
        public abstract double hitungLuas();

        public abstract double hitungKeliling();
    }
    class Persegi : BangunDatar
    {
        private double s;

        public double sisi
        {
            get { return s; }
            set { s = value; }
        }
        public override double hitungLuas()
        {
            _hitung = s * s;
            return _hitung;
        }
        public override double hitungKeliling()
        {
            _hitung = s * 4;
            return _hitung;
        }

    }
    class Lingkaran : BangunDatar
    {
        private double r, luas;

        public double jarijari
        {
            get { return r; }
            set
            {
                r = value;
            }
        }
        public override double hitungLuas()
        {
            luas = 3.14 * r * r;
            return luas;
        }
        public override double hitungKeliling()
        {
            float k = (float)(2 * Math.PI * r);
            return k;
        }
    }
    class PersegiPanjang : BangunDatar
    {
        private float p, l, luas;

        public float panjang
        {
            get { return p; }
            set
            {
                p = value;
            }
        }
        public float lebar
        {
            get { return l; }
            set
            {
                l = value;
            }
        }
        public override double hitungLuas()
        {
            luas = p * l;
            return luas;
        }
        public override double hitungKeliling()
        {
            float k = 2 * panjang + 2 * lebar;
            return k;
        }
    }
    class Segitiga
    {
        private float a, t, luas;
        public float alas
        {
            get { return a; }
            set
            {
                a = value;
            }
        }
        public float tinggi
        {
            get { return t; }
            set
            {
                t = value;
            }
        }
        public float luas_segitiga()
        {
            luas = (a * t) / 2;
            return luas;
        }
    }
}