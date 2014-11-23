using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3b
{
    //This class is based upon the Fraction example from MSDN: 
    //http://msdn.microsoft.com/en-us/library/s53ehcz3.aspx
    class Fraction
    {
        #region Fields

        int _getDenominator;

        #endregion
        #region Properties
        public int getNominator { get; private set; }
        public int getDenominator
        {
            get
            {
                return _getDenominator;
            }

            private set
            {
                if (value == 0)
                {
                    throw new FormatException(Strings.denominatorZeroError);
                }
                _getDenominator = value;
            }
        }

        #endregion

        #region Constructor

        public Fraction(int nominator, int denominator)
        {
            getNominator = nominator;
            getDenominator = denominator;
        }

        #endregion
    }
}
