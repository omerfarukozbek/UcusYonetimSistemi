using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcusYonetimSistemi.Enums;

namespace UcusYonetimSistemi.Classes
{
    public class Ucak
    {
        private int _ıd;

        public int Id
        {
            get { return _ıd; }
            set {
                if (value>0)
                {
                    _ıd = value;
                }
               
            }
        }
        public bool CalisirMi { get; set; }
        public UcakTipi ucakTipi { get; set; }
        public Pilot pilot { get; set; }
        public YardımcıPilot yardımcı { get; set; }

        public Ucak(int ıd, bool calisirMi, UcakTipi ucakTipi, Pilot pilot, YardımcıPilot yardımcı)
        {
            Id = ıd;
            CalisirMi = calisirMi;
            this.ucakTipi = ucakTipi;
            this.pilot = pilot;
            this.yardımcı = yardımcı;
        }
    }
}
