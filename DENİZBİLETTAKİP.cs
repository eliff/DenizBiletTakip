using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deniz_bilet_takip
{
     enum Yolcutürü { Öğrenci, Tam, Yaşlı, Engelli, Nakit }

    class DENİZBİLETTAKİP
    {
        private int öğrenciadet=0;
        private int tamadet=0;
        private int yaşlıadet=0;
        private int engelliadet=0;
        private int nakitadet=0;
        private string dosyaismi;
        DENİZBİLETTAKİP[] yolcu;

        //get set 
        public int Öğrenciadet { get => öğrenciadet; set => öğrenciadet = value; }
        public int Tamadet { get => tamadet; set => tamadet = value; }
        public int Yaşlıadet { get => yaşlıadet; set => yaşlıadet = value; }
        public int Engelliadet { get => engelliadet; set => engelliadet = value; }
        public int Nakitadet { get => nakitadet; set => nakitadet = value; }

        //yapıcı
        public DENİZBİLETTAKİP(string dosyaismi)
        {
            this.dosyaismi = dosyaismi;
            Dosyadanoku();
        }

        public void Bindir(Yolcutürü yolcu)
        {
            if (yolcu == Yolcutürü.Öğrenci)
            {
                öğrenciadet++;
            }
            else if (yolcu == Yolcutürü.Tam)
            {
                tamadet++;
            }
            else if (yolcu == Yolcutürü.Yaşlı)
            {
                yaşlıadet++;
            }
            else if (yolcu == Yolcutürü.Engelli)
            {
                engelliadet++;
            }
            else if (yolcu == Yolcutürü.Nakit)
            {
                nakitadet++;
                Durumkaydet();
            }
           
        }
        
        Yolcu[] yolcular = new Yolcu[500];
        int yolcusayısı = 0;

        public void ekle(Yolcu yolcu)
        {
            yolcular[yolcusayısı] = yolcu;
            yolcusayısı++;
        }
        public void listeyeekle(Yolcu yolcu)
        {
            yolcular[yolcusayısı] = yolcu;
            yolcusayısı++;
        }
        public void listele()
        {
            for(int i = 0; i < yolcusayısı; i++)
            {

                Console.WriteLine(yolcular[i].tostring());
                                   
            }
        }
        public void listeleögrenci(Yolcutürü yolcutürü)
        {
            for (int i = 0; i < yolcusayısı; i++)
            {
                if (yolcular[i] is öğrenci)
                {
                    Console.WriteLine(yolcular[i].tostring());

                }
            }
        }
        public void listeletam(Yolcutürü yolcutürü)
        {
            for (int i = 0; i < yolcusayısı; i++)
            {
                if (yolcular[i] is tam)
                {
                    Console.WriteLine(yolcular[i].tostring());

                }
            }
        }
        public void listeleyaşlı(Yolcutürü yolcutürü)
        {
            for (int i = 0; i < yolcusayısı; i++)
            {
                if (yolcular[i] is yaşlı)
                {
                    Console.WriteLine(yolcular[i].tostring());

                }
            }
        }
        public void listeleengelli(Yolcutürü yolcutürü)
        {
            for (int i = 0; i < yolcusayısı; i++)
            {
                if (yolcular[i] is engelli)
                {
                    Console.WriteLine(yolcular[i].tostring());

                }
            }
        }
        public void listelenakit(Yolcutürü yolcutürü)
        {
            for (int i = 0; i < yolcusayısı; i++)
            {
                if (yolcular[i] is nakit)
                {
                    Console.WriteLine(yolcular[i].tostring());

                }
            }
        }
        
        public void bindir(öğrenci öğrenci)
        {
            öğrenciadet++;
            Durumkaydet();
            ekle(öğrenci);          
        }
        public void bindir( tam tam)
        {
            öğrenciadet++;
            Durumkaydet();
            ekle(tam);
        }
        public void bindir(yaşlı yaşlı)
        {
            öğrenciadet++;
            Durumkaydet();
            ekle(yaşlı);
        }
        public void bindir(engelli engelli)
        {
            öğrenciadet++;
            Durumkaydet();
            ekle(engelli);
        }
        public void bindir(nakit nakit)
        {
            öğrenciadet++;
            Durumkaydet();
            ekle(nakit);
        }
        public void bindir(Yolcu yolcu)
        {
            if (yolcu is öğrenci)
            {
                öğrenciadet++;
            }
            else if (yolcu.GetType() == typeof(tam))
            {
                tamadet++;
            }
            else if (yolcu.GetType() == typeof(yaşlı))
            {
                yaşlıadet++;
            }
            else if (yolcu.GetType() == typeof(engelli))
            {
                engelliadet++;
            }
            else if (yolcu.GetType() == typeof(nakit))
            {
                nakitadet++;
            }
            Durumkaydet();
            ekle(yolcu);
        }
        public int Toplamyolcu()
        {
            return öğrenciadet + tamadet + yaşlıadet + engelliadet + nakitadet;
            
        }
        public double ciro()
        {
            return öğrenciadet * BİLETFİYAT.öğrenci + tamadet * BİLETFİYAT.tam + yaşlıadet * BİLETFİYAT.yaşlı + engelliadet * BİLETFİYAT.engelli + nakitadet * BİLETFİYAT.nakit;
        }
        public double ciroÖğrenci()
        {
            return öğrenciadet * BİLETFİYAT.öğrenci;
        }
        public double ciroTam()
        {
            return tamadet * BİLETFİYAT.tam;
        }
        public double ciroYaşlı()
        {
            return yaşlıadet * BİLETFİYAT.yaşlı;
        }
        public double ciroEngelli()
        {
            return engelliadet * BİLETFİYAT.engelli;
        }
        public double ciroNkait()
        {
            return nakitadet * BİLETFİYAT.nakit;
        }
        //to string
        public override string ToString()
        {
            return $"öğrenci:{ciroÖğrenci()},tam:{ciroTam()},yaşlı{ciroYaşlı()},engelli:{ciroEngelli()},nakit:{ciroNkait()}";
        }  
        public string ögrtostring()
        {
            return $"öğrenci:{öğrenciadet}";
        }
        public string tamtostring()
        {
            return $"tam:{tamadet}";
        }
        public string yaşlıtostring()
        {
            return $"yaşlı:{yaşlıadet}";
        }
        public string engellitostring()
        {
            return $"engelli:{engelliadet}";
        }
        public string nakittostring()
        {
            return $"nakit:{nakitadet}";
        }
        public string cirotostring()
        {
            return "ögrenci:" + ciroÖğrenci() + "\n" + "tam:" + ciroTam() + "\n" + "yaşlı:" + ciroYaşlı() + "\n" + "engelli:" + ciroEngelli() + "\n" + "nakit:" + ciroNkait();
        }
        public string sayactostring()
        {
            return $"ögrenci adet:{öğrenciadet}\n tam adet:{tamadet}\n yaşlı adet:{yaşlıadet}\n engelli adet:{engelliadet}\n nakit adet:{nakitadet}";
        }
        //dosya 
        private void Dosyadanoku()
        {
            StreamReader dosya = new StreamReader(dosyaismi);
            string kayıt = dosya.ReadLine();
            string[] alanlar;
            while (kayıt != null)
            {
                alanlar = kayıt.Split(';');
                öğrenciadet = Convert.ToInt32(alanlar[0]);
                tamadet = Convert.ToInt32(alanlar[1]);
                yaşlıadet = Convert.ToInt32(alanlar[2]);
                engelliadet = Convert.ToInt32(alanlar[3]);
                nakitadet = Convert.ToInt32(alanlar[4]);

                kayıt = dosya.ReadLine();
            }
            dosya.Close();
        }
        public void Durumkaydet()
        {
            StreamWriter dosya = new StreamWriter(dosyaismi, true);
            dosya.WriteLine(öğrenciadet+";"+tamadet+ ";"+yaşlıadet+ ";"+ engelliadet+ ";"+nakitadet);
            dosya.Flush();
            dosya.Close();
        }
        public void SonDurumOku()
        {

            StreamReader dosya = new StreamReader(dosyaismi);
            string kayıt = dosya.ReadLine();
            string[] alanlar;
            while (kayıt != null)
            {
               alanlar = kayıt.Split(';');
               öğrenciadet = Convert.ToInt32(alanlar[0]);
               tamadet = Convert.ToInt32(alanlar[1]);
               yaşlıadet = Convert.ToInt32(alanlar[2]);
               engelliadet = Convert.ToInt32(alanlar[3]);
               nakitadet = Convert.ToInt32(alanlar[4]);


               kayıt = dosya.ReadLine();
            }
             dosya.Close();
            
            


        }
        //yolcu oku kaydet
        public void yolcularıkaydet( )
        {
            StreamWriter dosya = new StreamWriter("yolcular.txt",true);
            for(int i = 0; i < yolcusayısı; i++)
            {
                dosya.WriteLine("{0};{1};{2};{3}", yolcular[i].Ad , yolcular[i].Soyad , yolcular[i].Akbilno ,(int)yolcular[i].Tür);
            }
            dosya.Flush();
            dosya.Close();           
        }
        
        public void yolcularıoku()
        {
            StreamReader dosya = new StreamReader("yolcular.txt");
            if (File.Exists("yolcular.txt"))
            {
                string kayıt = dosya.ReadLine();
                while (kayıt != null)
                {
                    string[] arraylist = kayıt.Split(';');
                    if ((Yolcutürü)Convert.ToInt32(arraylist[3]) == Yolcutürü.Öğrenci)
                    {
                        öğrenci öğrenci = new öğrenci(arraylist[0], arraylist[1], arraylist[2]);
                        yolcular[yolcusayısı] =öğrenci;
                        
                    }
                    else if ((Yolcutürü)Convert.ToInt32(arraylist[3]) == Yolcutürü.Tam)
                    {
                        tam tam = new tam(arraylist[0], arraylist[1], arraylist[2]);
                        yolcular[yolcusayısı] = tam;
                        
                    }
                    else if ((Yolcutürü)Convert.ToInt32(arraylist[3]) == Yolcutürü.Yaşlı)
                    {
                        yaşlı yaşlı = new yaşlı(arraylist[0], arraylist[1], arraylist[2]);
                        yolcular[yolcusayısı] = yaşlı;

                    }
                    else if ((Yolcutürü)Convert.ToInt32(arraylist[3]) == Yolcutürü.Engelli)
                    {
                        engelli engelli = new engelli(arraylist[4], arraylist[1], arraylist[2]);
                        yolcular[yolcusayısı] = engelli;

                    }
                    else //nakit
                    {
                        nakit nakit = new nakit(arraylist[0], arraylist[1], arraylist[2]);
                        yolcular[yolcusayısı] = nakit;

                    }
                    kayıt = dosya.ReadLine();
                    yolcusayısı++;

                     

                }
            }
        }

        //yıkıcı
        ~DENİZBİLETTAKİP()
        {
            StreamWriter dosya = new StreamWriter(dosyaismi);
            dosya.WriteLine(öğrenciadet + ";" + tamadet + ";" + yaşlıadet + ";" + engelliadet + ";" + nakitadet);
            dosya.Flush();
            dosya.Close();
        }
       
    }
}
