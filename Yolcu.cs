using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deniz_bilet_takip
{
    abstract class Yolcu
    {
        private string ad;
        private string soyad;
        private string akbilno;
        Yolcutürü tür;
        protected Yolcu(string ad, string soyad, string akbilno, Yolcutürü tür)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.akbilno = akbilno;
            this.Tür = tür;
        }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Akbilno { get => akbilno; set => akbilno = value; }
        internal Yolcutürü Tür { get => tür; set => tür = value; }

        public virtual string tostring()
        {
            return " adı:" + ad + "" + "soyad" + soyad + "" + "akbilno" + Akbilno;
        }
        abstract public double Biletfiyat();
    }
        class öğrenci : Yolcu
        {
            public öğrenci(string ad, string soyad, string akbilno) : base(ad, soyad, akbilno,Yolcutürü.Öğrenci)
            {

            }
            public override string ToString()
            {
                return base.tostring() + "yolcu türü:" + Yolcutürü.Öğrenci;
                
            }
            public override double Biletfiyat()
            {
                return BİLETFİYAT.öğrenci;
            }
        }
        class tam : Yolcu
        {
            public tam(string ad, string soyad, string akbilno) : base(ad, soyad, akbilno,Yolcutürü.Tam)
            {
            }
            public override string ToString()
            {
                return base.tostring() + "yolcu türü:" + Yolcutürü.Tam;

            }
            public override double Biletfiyat()
            {
                return BİLETFİYAT.tam;
            }
        }
        class yaşlı : Yolcu
        {
            public yaşlı(string ad, string soyad, string akbilno) : base(ad, soyad, akbilno,Yolcutürü.Yaşlı)
            {
            }
            public override string ToString()
            {
                return base.ToString() + "yolcu türü:" + Yolcutürü.Yaşlı;

            }
            public override double Biletfiyat()
            {
                return BİLETFİYAT.yaşlı;
            }

        }
        class engelli : Yolcu
        {
            public engelli(string ad, string soyad, string akbilno) : base(ad, soyad, akbilno,Yolcutürü.Engelli)
            {
            }
            public override string ToString()
            {
                return base.ToString() + "yolcu türü:" + Yolcutürü.Engelli;

            }
            public override double Biletfiyat()
            {
                return BİLETFİYAT.engelli;
            }
        }
        class nakit : Yolcu
        {
            public nakit(string ad, string soyad, string akbilno) : base(ad, soyad, akbilno,Yolcutürü.Nakit)
            {
            }
            public override string ToString()
            {
                return base.tostring() + "yolcu türü:" + Yolcutürü.Nakit;

            }
            public override double Biletfiyat()
            {
                return BİLETFİYAT.nakit  ;
            }
        }
       class BİNDİR
       {

            int ögrenciadet = 0, tamadet = 0, yaşlıadet = 0, engelliadet = 0, nakitadet = 0;

            public BİNDİR(int ögrenciadet, int tamadet, int yaşlıadet, int engelliadet, int nakitadet)
            {
                this.ögrenciadet = ögrenciadet;
                this.tamadet = tamadet;
                this.yaşlıadet = yaşlıadet;
                this.engelliadet = engelliadet;
                this.nakitadet = nakitadet;             
            }
            public void bindir(öğrenci ögrenci)
            {
                ögrenciadet++;
            }
            public void bindir(tam tam)
            {
                tamadet++;
            }
            public void bindir(yaşlı yaşlı)
            {
                yaşlıadet++;
            }
            public void bindir(engelli engelli)
            {
                engelliadet++;
            }
            public void  bindir(nakit nakit)
            {
                nakitadet++;
            }
            
            public void bindir(Yolcu yolcu)
            {
                if (yolcu is öğrenci)
                {
                    ögrenciadet++;
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
            }
             
       }
    
    
}
