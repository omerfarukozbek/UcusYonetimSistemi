using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusYonetimSistemi.Classes
{
    public class Ucus
    {
        private int _ıd;

        public int Id
        {
            get { return _ıd; }
            set
            {
                if (value > 0)
                {
                    _ıd = value;
                }

            }
        }
        public DateTime KalkisSaati { get; set; }


        public DateTime InisSaati { get; set; }
        public Double UcusSüresi { get; set; }

       
        public HavaAlanı InisHavaAlani { get; set; }
        public HavaAlanı KalkisHavaAlani { get; set; }
        public HavaYoluSirketi sirket { get; set; }

        public Ucus(int ıd, DateTime kalkisSaati,double UcusSüresi, HavaAlanı InisHavaAlani, HavaAlanı KalkisHavaAlani, HavaYoluSirketi sirket)
        {
            if (sirket.ucak.CalisirMi)
            {
                Id = ıd;
                KalkisSaati = kalkisSaati;
                InisSaati = kalkisSaati.AddHours(UcusSüresi);

                this.InisHavaAlani = InisHavaAlani;
                this.KalkisHavaAlani = KalkisHavaAlani;
                this.sirket = sirket;
            }
            else
            {
               //Console.WriteLine("Calısır durumda olmayan ucak ile ucus yapamazsınız");
                throw new Exception("Calısır durumda olmayan ucak ile ucus yapamazsınız");
                
                
            }
        }
            
    }
}
