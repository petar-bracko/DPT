using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbracko_zadaca_2
{
    public class TvProgram : IPrototype
    {
        private int _id;
        private String _naziv;
        private Adresa _adresa;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }
        public Adresa Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }
        
        public TvProgram(int id, String naziv, Adresa adresa)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Adresa = adresa;
        }

        public IPrototype Kloniraj()
        {
            TvProgram program = (TvProgram)this.MemberwiseClone();
            program.Adresa = Adresa.KloniranjeAdrese();
            return program;
        }
    }
}
