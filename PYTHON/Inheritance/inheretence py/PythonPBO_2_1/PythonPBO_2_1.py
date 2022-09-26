class BangunDatar:
    def Luas(self):
        print("\nLuas Bangun Datar Inheritance")
    def Keliling(self):
        print("Keliling Bangun Datar Inheritance")

class Persegi(BangunDatar):
    def sisi(self):
        pass

class PersegiPanjang(BangunDatar):
    def panjang(self):
        pass
    def lebar(self):
        pass

class Segitiga(BangunDatar):
    def alas(self):
        pass
    def tinggi(self):
        pass

class Lingkaran(BangunDatar):
    def jari(self):
        pass

class Main(object):
    print("Inheritance")
    print("\nPilih opsi operasi :")
    print("1. Persegi\n2. Lingkaran\n3. Persegi Panjang\n4. Segitiga")


    menu = int(input())

    if menu==1:
        persegi=Persegi()
        persegi.sisi = int(input("\nInput Sisi : "))
        persegi.Luas()
        persegi.Keliling()
    elif menu==2:
        lingkaran=Lingkaran()
        lingkaran.jari = int(input("\nInput Jari-Jari : "))
        lingkaran.Luas()
        lingkaran.Keliling()
    elif menu==3:
        persegipanjang=PersegiPanjang()
        persegipanjang.panjang = int(input("\nInput Panjang : "))
        persegipanjang.lebar = int(input("Input Lebar : "))
        persegipanjang.Luas()
        persegipanjang.Keliling()
    elif menu==4:
        segitiga=Segitiga()
        segitiga.alas = int(input("\nInput Alas : "))
        segitiga.tinggi = int(input("Input Tinggi : "))
        segitiga.Luas()
        segitiga.Keliling()