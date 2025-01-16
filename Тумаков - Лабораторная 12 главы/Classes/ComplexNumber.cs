namespace Тумаков___Лабораторная_12_главы.Classes
{
    public class ComplexNumber
    {
        public double Re { get; }
        public double Im { get; }

        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static ComplexNumber operator + (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re + b.Re, a.Im + b.Im);
        }

        public static ComplexNumber operator - (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re - b.Re, a.Im - b.Im);
        }

        public static ComplexNumber operator * (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + a.Im * b.Re);
        }

        public static bool operator == (ComplexNumber a, ComplexNumber b)
        {
            return a.Re == b.Re && a.Im == b.Im;
        }

        public static bool operator != (ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber example)
            {
                return this == example;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Re, Im);
        }

        public override string ToString()
        {
            if (Re == 0 && Im == 0) { return "нуль"; }
            else if (Im == 0) { return $"{Re}"; }
            else if (Re == 0) { return $"{Im}i"; }
            else return $"{Re} + {Im}i";
        }
    }
}
