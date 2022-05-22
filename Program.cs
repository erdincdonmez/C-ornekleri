<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information

int a = 10;
int b = 2;
a /= 2;
bool c = true;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

Console.ReadLine();

/*
Atama ve İşlemli Atama Operatörleri =, +=, -=, *=, /=
Mantıksal Operatörler               ||, &&, !
İlişkisel Operatörler               ==,!=, <, >, >=,<=
Aritmetik                           +, -, *, /, %, ++, --
*/
=======
﻿//    Telefon rehberi uygulaması
using System;
namespace Program{
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        rehber Rehberim = new rehber();
        while (true){
            Console.WriteLine("        Telefon Rehberim                ");
            Console.WriteLine(" =======================================");
            //Console.WriteLine("  Rehberinizde toplam "+Rehberim.Count.ToString()+" adet kayıt var.\n");
            Console.WriteLine("  1-Telefon Numarası Kaydet");
            Console.WriteLine("  2-Telefon Numarası Sil");
            Console.WriteLine("  3-Telefon Numarası Güncelle");
            Console.WriteLine("  4-Rehber Listeleme (A-Z, Z-A seçimli)");
            Console.WriteLine("  5-Rehberde Arama");
            Console.WriteLine("  6-Çıkış\n");  
            Console.Write    ("  Bir işlem seçip Entera basınız: ");             
            int secim = int.Parse(Console.ReadLine());
            switch (secim){
                case 1 : // kaydetme
                    Console.Write("İsim   : ");
                    string ad  = Console.ReadLine();
                    Console.Write("Telefon: ");
                    string tel = Console.ReadLine();
                    Rehberim.Ekle(ad,tel);
                    break;
                case 2 : //silme
                    Console.Write("Silinecek isim : ");
                    Rehberim.Sil(Console.ReadLine());
                    break; 
                case 3 : // güncelleme
                    Console.Write("Güncellenecek isim : ");
                    Rehberim.Guncelle(Console.ReadLine());
                    break;       
                case 4 : // sıralama
                    break;       
                case 5 : // arama
                    Console.Write("Aradığınız isim : ");
                    Console.WriteLine(Rehberim._adiSoyadi+" "+Rehberim._telefonu);
                    Console.ReadKey();
                    break;       
                case 6 : // çıkış
                    Console.WriteLine("Çıkmak istediğinizden emin misiniz(Y/N)");
                    string cevap = Console.ReadLine();
                    if (cevap=="Y")
                    Environment.Exit(0);
                    break;       
            }
        }
    }
}
class rehber{
        private IDictionary<string, string> rehberim = new Dictionary<string, string>();
        public string _adiSoyadi="";
        public string _telefonu="";

        public IDictionary<string, string> Rehberim { get => rehberim; set => rehberim = value; }

    public void Ekle(string adiSoyadi, string telefonu){
        Rehberim.Add(adiSoyadi,telefonu);
        Console.WriteLine(adiSoyadi+" "+telefonu+" eklendi.");
        Console.WriteLine("Rehberinizde toplam "+Rehberim.Count+" adet kayıt var.");
        Console.ReadKey();
    }
    public void Sil(string adiSoyadi){
        if (Rehberim[adiSoyadi]!="") {
            Console.Write("Silmek istediğinizden emin misiniz(Y/N) :");
            string cevap = Console.ReadLine();
            if (cevap=="Y"){
                Rehberim.Remove(adiSoyadi);
                Console.WriteLine(adiSoyadi+" silindi.");
            }
            else Console.WriteLine(adiSoyadi+" kaydını silmekten vaz geçtiniz");
        } 
        else Console.WriteLine(adiSoyadi+" kaydı yok.");
        Console.ReadKey();
    }
    public void Guncelle(string adiSoyadi){
        if (Rehberim[adiSoyadi]!="") {
            Console.WriteLine(Rehberim[adiSoyadi]+" kaydı var.");
            Console.Write("Guncellemek istediğinizden emin misiniz(Y/N) :");
            string cevap = Console.ReadLine();
            if (cevap=="Y"){
                Rehberim.Remove(adiSoyadi);
                Console.WriteLine(adiSoyadi+" guncellendi.");
            }
            else Console.WriteLine(adiSoyadi+" kaydını guncellemekten vaz geçtiniz");
        } 
        else Console.WriteLine(adiSoyadi+" kaydı yok.");
        Console.ReadKey();

    }

}
>>>>>>> Stashed changes

}