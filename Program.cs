using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deniz_bilet_takip
{
    enum Anamenü { Yolcubiniş=1,Tümcirobilgisi,Tümsayaçbilgisi,Hepsinigöster,yolcubiniş,Listele,Çıkış}
    class Program
    {
        static void Main(string[] args)
        {
            
            DENİZBİLETTAKİP deniz = new DENİZBİLETTAKİP("biletfiyat.txt");

            /*
            öğrenci öğrenci = new öğrenci("bilinmeyen", "bilinmeyen", "00000");
            tam tam = new tam("bilinmeyen", "bilinmeyen", "00000");
            yaşlı yaşlı = new yaşlı("bilinmeyen", "bilinmeyen", "00000");
            engelli engelli = new engelli("bilinmeyen", "bilinmeyen", "00000");
            nakit nalit = new nakit("bilinmeyen", "bilinmeyen", "00000");
            */


            string ad, soyad, akbilno;
            
            deniz.Bindir(Yolcutürü.Nakit);           
            deniz.Bindir(Yolcutürü.Öğrenci);
            deniz.Bindir(Yolcutürü.Öğrenci);
            deniz.Bindir(Yolcutürü.Tam);
            deniz.Bindir(Yolcutürü.Tam);
            deniz.Bindir(Yolcutürü.Yaşlı);
            deniz.Bindir(Yolcutürü.Engelli);

           
            Console.WriteLine("********************************************");
            Console.WriteLine(deniz.ciroNkait());
            Console.WriteLine(deniz.ciroÖğrenci());
            Console.WriteLine(deniz.ciroTam());
            Console.WriteLine(deniz.ciroYaşlı());
            Console.WriteLine(deniz.ciroEngelli());
            Console.WriteLine("********************************************");
            Console.WriteLine(deniz.ciro());

            Console.WriteLine(deniz.ToString());
            Console.WriteLine("********************************************");
            Console.WriteLine(deniz.ögrtostring());
            Console.WriteLine(deniz.tamtostring());
            Console.WriteLine(deniz.yaşlıtostring());
            Console.WriteLine(deniz.engellitostring());
            Console.WriteLine(deniz.nakittostring());

            Console.WriteLine("elif");

            Anamenü seçim;
            do
            {
                

                Console.WriteLine("---------MENÜ---------");
                
                Console.WriteLine("1.YOLCU BİNİŞ(SINIF):");
                Console.WriteLine("2.TÜM CİRO BİLGİSİ:");
                Console.WriteLine("3.TÜM SAYAÇ BİLGİSİ:");
                Console.WriteLine("4.HEPSİNİ GÖSTER:");
                Console.WriteLine("5.YOLCU BİNİŞ:");
                Console.WriteLine("6.LİSTELE:");
                Console.WriteLine("7.ÇIKIŞ");
                seçim = (Anamenü)Convert.ToInt32(Console.ReadLine());
                if (seçim == Anamenü.Yolcubiniş)
                {
                    Console.WriteLine("1.öğrenci  2.tam  3.yaşlı  4.engelle  5.nakit");
                    Console.WriteLine("yolcu türü giriniz:");
                    Yolcutürü yolcu = (Yolcutürü)Convert.ToInt32(Console.ReadLine());
                    deniz.Bindir(yolcu);
                    deniz.Durumkaydet();
                }
                else if (seçim == Anamenü.Tümcirobilgisi)
                {
                    Console.WriteLine(deniz.cirotostring());
                    Console.WriteLine("toplam:" + deniz.ciro());
                    Console.WriteLine("devam etmek için enter'a basınız:");
                    Console.ReadKey();

                }
                else if (seçim == Anamenü.Tümsayaçbilgisi)
                {
                    Console.WriteLine(deniz.sayactostring());
                    Console.WriteLine("devam etmek için enter'a basınız:");
                    Console.ReadKey();
                }
                else if (seçim == Anamenü.Hepsinigöster)
                {
                    deniz.Bindir(Yolcutürü.Öğrenci);
                    deniz.Bindir(Yolcutürü.Öğrenci);
                    deniz.Bindir(Yolcutürü.Tam);
                    deniz.Bindir(Yolcutürü.Tam);
                    deniz.Bindir(Yolcutürü.Yaşlı);
                    deniz.Bindir(Yolcutürü.Engelli);



                    Console.WriteLine("********************************************");
                    Console.WriteLine(deniz.ciroNkait());
                    Console.WriteLine(deniz.ciroÖğrenci());
                    Console.WriteLine(deniz.ciroTam());
                    Console.WriteLine(deniz.ciroYaşlı());
                    Console.WriteLine(deniz.ciroEngelli());
                    Console.WriteLine("********************************************");
                    Console.WriteLine(deniz.ciro());

                    Console.WriteLine(deniz.ToString());
                    Console.WriteLine("********************************************");
                    Console.WriteLine(deniz.ögrtostring());
                    Console.WriteLine(deniz.tamtostring());
                    Console.WriteLine(deniz.yaşlıtostring());
                    Console.WriteLine(deniz.engellitostring());
                    Console.WriteLine(deniz.nakittostring());
                    Console.WriteLine("toplam yolcu:" + deniz.Toplamyolcu());
                }
                else if (seçim == Anamenü.yolcubiniş)
                {
                    Console.WriteLine("bilet türü seçiniz:");
                    Console.WriteLine("1.öğrenci:");
                    Console.WriteLine("2.tam:");
                    Console.WriteLine("3.yaşlı:");
                    Console.WriteLine("4.engelli:");
                    Console.WriteLine("5.nakit:");
                    int binenyolcu = Convert.ToInt32(Console.ReadLine());
                    if (binenyolcu == 1)
                    {
                        Console.WriteLine("ad:");
                        ad = Console.ReadLine();
                        Console.WriteLine("soyad:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("akbilno:");
                        akbilno = Console.ReadLine();
                        öğrenci yolcu1 = new öğrenci(ad, soyad, akbilno);
                        deniz.bindir(yolcu1);
                        Console.WriteLine(yolcu1.ToString());
                    }
                    else if (binenyolcu == 2)
                    {
                        Console.WriteLine("ad:");
                        ad = Console.ReadLine();
                        Console.WriteLine("soyad:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("akbilno:");
                        akbilno = Console.ReadLine();
                        tam yolcu2 = new tam(ad, soyad, akbilno);
                        deniz.bindir(yolcu2);
                        Console.WriteLine(yolcu2.ToString());
                    }

                    else if(binenyolcu == 3)
                    {
                        Console.WriteLine("ad:");
                        ad = Console.ReadLine();
                        Console.WriteLine("soyad:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("akbilno:");
                        akbilno = Console.ReadLine();
                        yaşlı yolcu3 = new yaşlı(ad, soyad, akbilno);
                        deniz.bindir(yolcu3);
                        Console.WriteLine(yolcu3.ToString());
                    }
                    else if (binenyolcu == 4)
                    {
                        Console.WriteLine("ad:");
                        ad = Console.ReadLine();
                        Console.WriteLine("soyad:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("akbilno:");
                        akbilno = Console.ReadLine();
                        engelli yolcu4 = new engelli(ad, soyad, akbilno);
                        deniz.bindir(yolcu4);
                        Console.WriteLine(yolcu4.ToString());
                    }
                    else if (binenyolcu == 5)
                    {
                        Console.WriteLine("ad:");
                        ad = Console.ReadLine();
                        Console.WriteLine("soyad:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("akbilno:");
                        akbilno = Console.ReadLine();
                        nakit yolcu5 = new nakit(ad, soyad, akbilno);
                        deniz.bindir(yolcu5);
                        Console.WriteLine(yolcu5.ToString());
                    }
                    deniz.yolcularıkaydet();
                }
                else if (seçim == Anamenü.Listele)
                {
                    ConsoleKeyInfo listeseç;
                    do
                    {
                        Console.WriteLine("(H)EPSİ:");
                        Console.WriteLine("(O)ĞRENCİLER:");
                        Console.WriteLine("(T)AM:");
                        Console.WriteLine("(Y)AŞLI:");
                        Console.WriteLine("(E)NGELLİ:");
                        Console.WriteLine("(N)AKİT:");
                        Console.WriteLine("(U)ST MENÜ");
                        listeseç = Console.ReadKey();
                        if (listeseç.Key == ConsoleKey.H)
                        {
                            deniz.listele();
                        }
                        else if (listeseç.Key == ConsoleKey.O)
                        {
                            deniz.listeleögrenci(Yolcutürü.Öğrenci);
                            deniz.yolcularıoku();
                        }
                        else if (listeseç.Key == ConsoleKey.T)
                        {
                            deniz.listeletam(Yolcutürü.Nakit);
                            deniz.yolcularıoku();
                        }
                        else if (listeseç.Key == ConsoleKey.Y)
                        {
                            deniz.listeleyaşlı(Yolcutürü.Yaşlı);
                            deniz.yolcularıoku();
                            deniz.listele();                                                                                                                                   
                        }
                        else if (listeseç.Key == ConsoleKey.E)
                        {
                            deniz.listeleengelli(Yolcutürü.Engelli);
                            deniz.yolcularıoku();
                        }
                        else if (listeseç.Key == ConsoleKey.N)
                        {
                            deniz.listelenakit(Yolcutürü.Nakit);
                            deniz.yolcularıoku();
                        }
                    } while (listeseç.Key != ConsoleKey.U);

                }
            } while (seçim != Anamenü.Çıkış);
            
            Console.Read();
        }
    }
}
