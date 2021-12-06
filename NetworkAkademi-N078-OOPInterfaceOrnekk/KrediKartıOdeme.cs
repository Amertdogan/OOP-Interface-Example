using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NetworkAkademi_N078_OOPInterfaceOrnekk
{
    public class KrediKartıOdeme : Odeme, Iodeme
    {
        public string kartSahibiAdi { get; set; }
        public string kartSahibiSoyAdi { get; set; }
        public byte sonKullanımAy { get; set; }
        public int sonKullanımYılı { get; set; }
        public short cvv{ get; set; }

        private string _kartNumarası;

        public string kartNumarası
        {
            get
            {
                return _kartNumarası; 
            }   
            set 
            {
                char[] dizi = value.ToCharArray();
                bool rakamDegilMi = false;
                foreach (var item in dizi)
                {
                    if (!char.IsDigit(item))//digit olmayan varsa
                    {
                        rakamDegilMi = true;//hemen yakala
                        break;
                    }
                }
                if (!rakamDegilMi && value.Length==16)
                {
                    _kartNumarası = value;
                }
                else
                {
                    throw new FormatException("HATA: Kart numarası 16 haneli değil veya uygun formatta girilmemiştir.");
                }
            }
        }





       public  void odemeSekliAyariYap()
        {
            Console.WriteLine("Kredi Kartı---> 1");
        }

        public void odemeYap()
        {
            Console.WriteLine("Kart sahibi adını giriniz");
            kartSahibiAdi = Console.ReadLine();
            Console.WriteLine("Kart sahibi soy adını giriniz");
            kartSahibiSoyAdi = Console.ReadLine();
            Console.WriteLine("16 haneli kart numaranızı giriniz.");
            kartNumarası = Console.ReadLine();
            Console.WriteLine("Kartın son kullanma ayını giriniz(1-12 arasında olmalı).");
            sonKullanımAy = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Kartın son kullanma yılını giriniz.(20XX)");
            sonKullanımYılı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kartın arkasındaki cvv numarasını  giriniz.(3 haneli olmalı)");
            cvv = Convert.ToInt16(Console.ReadLine());

            //KART NUMARASI BOS OLMAMALI VE DİĞER ÖZELLİKLERDE BOS OLMAMALI ENCAPSULATION YAP
            //BU İF'İN İÇİNDE KOSULLAR ENCAPSULATION İLE GERÇEKLEŞTİRİNİZ.
            if (kartSahibiAdi.Length>0 && kartSahibiSoyAdi.Length>0 &&sonKullanımAy>0 && sonKullanımAy<13 && sonKullanımYılı>=DateTime.Now.Year)
            {
                Console.Clear();
                Console.WriteLine($"Sayın {kartSahibiAdi} {kartSahibiSoyAdi} {odenecekTutar} TL kartınızdan cekiliyor..Lütfen bekleyiniz.");
                Random rnd = new Random();
                int bekleme = rnd.Next(3000, 5000);
                Thread.Sleep(bekleme);
                Console.WriteLine("Ödeme alındı..");

            }
        }
    }
}
