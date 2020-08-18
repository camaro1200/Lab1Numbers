using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab1Csharp
{
    public class Timurka
    {
        public class RationalNumber
        {
            public int numerator;
            public int denominator;

            public RationalNumber(int numerator, int denominator)
            {
                this.denominator = denominator;
                this.numerator = numerator;
            }
        }

        public class FractionSet
        {
            public List<RationalNumber> Array = new List<RationalNumber>();

            public void addNumber(RationalNumber x)
            {
                Array.Add(x);
            }

            public RationalNumber maxFraction()
            {
                RationalNumber result = Array[0];
                double kek = Array[0].numerator/Array[0].denominator;
                foreach (RationalNumber x in Array)
                {
                    if (kek < x.numerator / x.denominator)
                    {
                        kek = x.numerator / x.denominator;
                        result = x;
                    }
                }

                return result;
            }
            
            public RationalNumber minFraction()
            {
                RationalNumber result = Array[0];
                double kek = Array[0].numerator/Array[0].denominator;
                foreach (RationalNumber x in Array)
                {
                    if (kek > x.numerator / x.denominator)
                    {
                        kek = x.numerator / x.denominator;
                        result = x;
                    }
                }

                return result;
            }
        }

        public static void Main(string[] args)
        {
            RationalNumber xyu = new RationalNumber(3,4);
            RationalNumber xyu1 = new RationalNumber(1,4);
            RationalNumber xyu2 = new RationalNumber(2,4);
            RationalNumber xyu3 = new RationalNumber(1,3);
            
            FractionSet FR = new FractionSet();
            
            FR.addNumber(xyu);
            FR.addNumber(xyu1);
            FR.addNumber(xyu2);
            FR.addNumber(xyu3);

            Console.WriteLine(FR.maxFraction().numerator + " " + FR.maxFraction().denominator );
            Console.WriteLine(FR.minFraction().numerator + " " + FR.minFraction().denominator );
        } 
    }
}