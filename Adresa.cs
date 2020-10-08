using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbracko_zadaca_2
{
    public class Adresa
    {
        private int _broj;
        private String _ulica;

        public int Broj
        {
            get { return _broj; }
            set { _broj = value; }
        }
        public String Ulica
        {
            get { return _ulica; }
            set { _ulica = value; }
        }

        public Adresa(int broj, String ulica)
        {
            this.Broj = broj;
            this.Ulica = ulica;
        }

        public Adresa KloniranjeAdrese()
        {
            return (Adresa)this.MemberwiseClone();
        }
    }
}
