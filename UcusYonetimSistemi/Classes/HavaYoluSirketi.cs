using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusYonetimSistemi.Classes
{
    public class HavaYoluSirketi
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
        public string Name { get; set; }

        public Ucak ucak { get; set; }

        public HavaYoluSirketi(int ıd, string name, Ucak ucak)
        {
            Id = ıd;
            Name = name;
            this.ucak = ucak;
        }
    }
}
