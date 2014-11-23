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

        #region Methods

        public bool isNegativ()
        {
            if (getNominator < 0 || getDenominator < 0)
            {
                return true;
            }
            return false;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.getNominator * b.getNominator, a.getDenominator * b.getDenominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.getNominator * b.getDenominator + b.getNominator * a.getDenominator,
                a.getDenominator * b.getDenominator);
        }

        public bool isEqualTo(Fraction a){

            int fractionA = Convert.ToInt32((Convert.ToDouble(a.getNominator) / Convert.ToDouble(a.getDenominator)) * Convert.ToDouble(10000000));
            int fractionB = Convert.ToInt32((Convert.ToDouble(getNominator) / Convert.ToDouble(getDenominator)) * Convert.ToDouble(10000000));

            if (fractionA == fractionB)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (getNominator == getDenominator)
            {
                return "1";
            }
            return getNominator + "/" + getDenominator;
        }

        #endregion
    }
}
