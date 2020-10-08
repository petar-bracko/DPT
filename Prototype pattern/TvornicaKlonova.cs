using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbracko_zadaca_2
{
    public class TvornicaKlonova
    {
        private static TvornicaKlonova _instacnaTvorniceKlonova = null;

        public static TvornicaKlonova GetInstance()
        {
            if (_instacnaTvorniceKlonova == null)
            {
                _instacnaTvorniceKlonova = new TvornicaKlonova();
            }
            return _instacnaTvorniceKlonova;
        }
        public IPrototype getClone(IPrototype prototip)
        {
            return prototip.Kloniraj();
        }
    }
}
