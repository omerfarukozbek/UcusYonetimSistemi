using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusYonetimSistemi.Classes
{
    public class Pilot
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
        public string SurName { get; set; }
        public int Deneyim { get; set; }

        public Pilot(int ıd, string name, string surName, int deneyim)
        {
            Id = ıd;
            Name = name;
            SurName = surName;
            Deneyim = deneyim;
        }
    }
}
