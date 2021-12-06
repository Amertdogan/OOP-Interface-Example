using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NetworkAkademi_N078_OOPInterfaceOrnekk
{
    public class FastPayOdeme:Odeme,Iodeme
    {
        
        public string E_posta { get; set; }
        public string Sifre { get; set; }

        public void odemeSekliAyariYap()
        {
            Console.WriteLine("FastPay ile ödeme---> 3");
        }

        public void odemeYap()
        {
            Console.WriteLine("Eposta adresini giriniz:");
            E_posta = Console.ReadLine();

            Console.WriteLine("Sifre giriniz: ");
            Sifre = Console.ReadLine();
            Random rnd = new Random();
            int bekleme = rnd.Next(3000, 5000);
            Console.WriteLine(bekleme);
            for (int i = 0; i < bekleme; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i+"...");
                Thread.Sleep(bekleme);
            }
            Console.WriteLine("Ödeme alındı.....İyi günler...");
        }
    }
}
