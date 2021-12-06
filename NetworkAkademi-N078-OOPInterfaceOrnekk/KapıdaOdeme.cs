using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N078_OOPInterfaceOrnekk
{
    public class KapıdaOdeme:Odeme,Iodeme
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyAdi { get; set; }
   

        public string TcNo { get; set; }


        public string Adress { get; set; }

        public string kuryeBilgisi { get; set; }

        public void odemeSekliAyariYap()
        {
            Console.WriteLine("Kapıda Ödeme--> 2");
        }

        public void odemeYap()
        {
            Console.WriteLine("Teslimat yapan kuryenin adı soyadı: ");
            kuryeBilgisi = Console.ReadLine();
            Console.WriteLine("Hasarsız mı? ");
            if (Console.ReadKey().Key==ConsoleKey.E)
            {
                Console.WriteLine("Teslimat basarılı.");
            }
            else
            {
                Console.WriteLine("Teslimat basarısız.");
            }
        }
    }
}
