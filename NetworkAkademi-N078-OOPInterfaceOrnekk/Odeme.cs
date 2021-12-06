using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N078_OOPInterfaceOrnekk
{
    public class Odeme
    {
        private decimal _odenecekTutar;

        public decimal odenecekTutar
        {
            get { return _odenecekTutar; }
            set { _odenecekTutar = value; }
        }
        public void OdemeTutariniKullanicidanAl()
        {
            Console.WriteLine("Ödenecek tutarı giriniz :");
            _odenecekTutar = Convert.ToDecimal(Console.ReadLine());

        }

    }
}
