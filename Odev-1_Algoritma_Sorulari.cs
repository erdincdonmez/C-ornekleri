/*

Ödev-1 Algoritma soruları

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


class Odev_1
{
    Console.Write("Kaç sayı girmek istersiniz: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("==================================");
    for (int i = 0; i < n; i++)
    {
        Console.Write(i+1 + ".sayıyı giriniz: ");
        int nn = int.Parse(Console.ReadLine());
        if (nn%2==0) Console.WriteLine("Çift sayı girdiniz");
        else Console.WriteLine("Tek sayı girdiniz");
    }
}*/