using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class ComplexNumber
    {
        #region Filed
        public double Real { get; set; }
        public double Imaginary { get; set; }

        #endregion

        #region Constructor
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        #endregion

        #region Methods
        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber( (c1?.Real ?? 0) + (c2?.Real ?? 0) , (c1?.Imaginary ?? 0) + (c2?.Imaginary ?? 0) );
        }
        public static ComplexNumber operator - (ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber( (c1?.Real ?? 0) - (c2?.Real ?? 0), (c1?.Imaginary ?? 0) - (c2?.Imaginary ?? 0) );
        }
        public static ComplexNumber operator ++ (ComplexNumber c)
        {
            return new ComplexNumber ((c?.Real ?? 0) + 1 , c?.Imaginary ?? 0);
        }
        public static ComplexNumber operator -- (ComplexNumber c)
        {
            return new ComplexNumber((c?.Real ?? 0) -1 , c?.Imaginary ?? 0);
        }
        public static bool operator > (ComplexNumber c1, ComplexNumber c2)
        {
            if (c1?.Real == c2?.Real)
                return c1?.Imaginary > c2?.Imaginary;
            else
                return c1?.Real > c2?.Real; 
        }
        public static bool operator < (ComplexNumber c1, ComplexNumber c2)
        {
            if (c1?.Real == c2?.Real)
                return c1?.Imaginary < c2?.Imaginary;
            else
                return c1?.Real < c2?.Real;
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        #endregion

    }
}
