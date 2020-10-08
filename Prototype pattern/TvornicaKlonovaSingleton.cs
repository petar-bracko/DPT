using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbracko_zadaca_2
{
    public class TvornicaKlonovaSingleton
    {
        private static TvornicaKlonovaSingleton _instacnaTvorniceKlonova = null;

        public static TvornicaKlonovaSingleton GetInstance()
        {
            if (_instacnaTvorniceKlonova == null)
            {
                _instacnaTvorniceKlonova = new TvornicaKlonovaSingleton();
            }
            return _instacnaTvorniceKlonova;
        }
        public IPrototype getClone(IPrototype prototip)
        {
            return prototip.Kloniraj();
        }
    }
}
