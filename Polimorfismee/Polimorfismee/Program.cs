﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();
            Console.ReadLine();
        }

        class Menu
        {
            public void menu()
            {
                Console.WriteLine("Program Polimorfisme Bangun Datar Dan Luas");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pilihan Menu:");
                Console.WriteLine("A. Persegi");
                Console.WriteLine("B. Lingkaran");
                Console.WriteLine("C. Segitiga");

                Console.WriteLine();

                Persegi D = new Persegi();

                Console.WriteLine("A. Menghitung Persegi");
                Console.Write("Masukan Sisi : ");
                D.sisi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas : {0} cm", D.hitungLuas());
                Console.WriteLine("Keliling : {0} cm", D.hitungKeliling());
                Console.WriteLine();

                Lingkaran d = new Lingkaran();

                Console.WriteLine("B. Menghitung Lingkaran");
                Console.Write("Masukan Jari-Jari : ");
                d.jarijari = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas       = {0} cm", d.hitungLuas());
                Console.WriteLine("Keliling   = {0} cm", d.hitungKeliling());
                Console.WriteLine();

                Segitiga c = new Segitiga();

                Console.WriteLine("C. Menghitung Segitiga");
                Console.Write("Masukan Alas   : ");
                c.alas = (int.Parse(Console.ReadLine()));
                Console.Write("Masukan Tinggi : ");
                c.tinggi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas   = {0} cm", c.hitungLuas());
                Console.Write("Masukan Sisi : ");
                c.sisi2 = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Keliling   = {0} cm", c.hitungKeliling());
                Console.ReadKey();
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

            public class Persegi : BangunDatar
            {
                private double s;

                public double sisi
                {
                    get { return s; }
                    set { s = value; }
                }

                public Persegi()
                {
                    this.sisi = sisi;
                }

                public override double hitungLuas()
                {
                    return this.sisi * this.sisi;
                }
                public override double hitungKeliling()
                {
                    return this.sisi * 4;
                }
            }

            public class Segitiga
            {
                private float a, t, x;

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
                public float sisi2
                {
                    get { return x; }
                    set
                    {
                        x = value;
                    }
                }

                public Segitiga()
                {
                    this.alas = alas;
                    this.tinggi = tinggi;
                }
                public float hitungLuas()
                {
                    return this.alas * this.tinggi / 2;
                }
                public float hitungKeliling()
                {
                    return this.sisi2 + this.sisi2 + this.sisi2;
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
                public Lingkaran()
                {
                    this.jarijari = r;
                }

                public override double hitungLuas()
                {
                    return (float)(Math.PI * r * r);
                }

                public override double hitungKeliling()
                {
                    return (float)(2 * Math.PI * r);
                }
            }
        }
    }
}