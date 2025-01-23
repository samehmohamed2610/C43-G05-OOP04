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
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        #endregion

    }
}
