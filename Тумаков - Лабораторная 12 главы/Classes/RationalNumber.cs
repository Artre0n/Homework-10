namespace Тумаков___Лабораторная_12_главы.Classes
{
    public class RationalNumber
    {
        public int numerator;
        public int denominator;

        public int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void Simplify()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равным нулю");
            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }
        #region +, -, *, /, %
        public static RationalNumber operator + (RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static RationalNumber operator - (RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static RationalNumber operator * (RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        public static RationalNumber operator / (RationalNumber a, RationalNumber b)
        {
            if (b.numerator == 0)
                throw new DivideByZeroException("Знаменатель не может быть равным нулю");
            return new RationalNumber(a.numerator * b.denominator, a.denominator * b.numerator);
        }
        public static RationalNumber operator % (RationalNumber a, RationalNumber b)
        {
            return a - (b * (a / b));
        }
        #endregion
        #region >, <, <=, >=
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return b > a;
        }
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a > b || a == b;
        }
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return b >= a;
        }
        #endregion
        #region ==, !=, ++, --
        public static bool operator == (RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }

        public static bool operator != (RationalNumber a, RationalNumber b)
        {
            return !(a == b);

        }
        public static RationalNumber operator ++(RationalNumber a)
        {
            return a + new RationalNumber(1, 1);
             
        }
        public static RationalNumber operator --(RationalNumber a)
        {
            return a - new RationalNumber(1, 1);

        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumber other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }
        #endregion
        public static explicit operator float(RationalNumber a)
        {
            return (float)a.numerator / a.denominator;
        }

        public static explicit operator int(RationalNumber a)
        {
            return a.numerator / a.denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

    }
}
