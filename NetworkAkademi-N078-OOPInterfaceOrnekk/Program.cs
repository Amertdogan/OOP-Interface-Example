using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N078_OOPInterfaceOrnekk
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-FastpayOdemede Eposta ve sifre bilgisi isteyip ekran rengi thread ile bir random bekleme süresi belirtip ekran rengi değişsin.Ödeme alındı ise ödeme alındı bilgisi verilsin.
            //2-KapidaOdemede teslimatı yapan kuryenin ad soyad kurye bilgisi istensin.Hasarsız mı diye sorsun Evet ise teslimat basarılı H ise basarısız teslimat olsun.
            //3-KrediKartıOdemede tüm kart bilgileri uygun bir bir şekilde istenip doğru olup olmadıgı kontrol edilsin.
            KrediKartıOdeme k1 = new KrediKartıOdeme();
            KapıdaOdeme kapı1 = new KapıdaOdeme();
            FastPayOdeme fast1 = new FastPayOdeme();

            List<KeyValuePair<byte, Iodeme>> OdemeTuruListesi = new List<KeyValuePair<byte, Iodeme>>()
            {
                new KeyValuePair<byte, Iodeme>(1,k1),
                new KeyValuePair<byte, Iodeme>(2,kapı1),
                new KeyValuePair<byte, Iodeme>(3,fast1)
            };

            foreach (var item in OdemeTuruListesi)
            {
                item.Value.odemeSekliAyariYap();
            }

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Kredi kartıyla ödeme yapmayı seçtiniz.");
                    k1.OdemeTutariniKullanicidanAl();
                    k1.odemeYap();
                    break;
                case 2:
                    Console.WriteLine("Kapıda ödeme yapmayı seçtiniz.");
                    kapı1.OdemeTutariniKullanicidanAl();
                    kapı1.odemeYap();
                    break;
                case 3:
                    Console.WriteLine("FastPay ile ödeme yapmayı seçtiniz.");
                    fast1.OdemeTutariniKullanicidanAl();
                    fast1.odemeYap();
                    break;

                default:
                    Console.WriteLine("Hatalı secim.");
                    break;
            }
           

        }
    }
}
