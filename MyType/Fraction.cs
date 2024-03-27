using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyType
{
    public class Fraction //Дробь
    {
        private int numerator; //Числитель
        private int denominator; //Знаменатель

        public int getNumerator()
        {
            return numerator;
        }
        public int getDenominator()
        {
            return denominator;
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            normilize();
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator;
            int newDenominator = a.denominator * b.numerator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.numerator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }



        public override string ToString()
        {
            if (numerator == 0 || denominator == 0)
                return "0";
            else if (denominator == 1)
                return numerator.ToString();
            else
                return $"{numerator}/{denominator}";
        }

        public void normilize()
        {
            //Два минуса
            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            //Минус в знаменателе
            else if (denominator < 0)
            {
                denominator = Math.Abs(denominator);
                numerator = numerator * (-1);
            }
            //Сокращение числителеля и знаменателя
            int gcd = findMax(Math.Abs(numerator), Math.Abs(denominator));
            if (gcd > 1)
            {
                numerator /= gcd;
                denominator /= gcd;
            }
        }
        //Алгоритм Евклида на поиск наибольшего общего делителя
        public int findMax(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public string sravn(Fraction fr2)
        {
            if (this.denominator == fr2.getNumerator()) //Знаменатели одинаковые
            {
                int Num1 = this.numerator;
                int Num2 = fr2.getNumerator();
                if (Num1 > Num2)
                {
                    return ">";
                }
                else if (Num1 < Num2)
                {
                    return "<";
                }
                else
                    return "=";
            }
            else //Знаменатели разные
            {
                //Необходимо привести к общему знаменателю
                int Den1 = this.denominator;
                int Den2 = fr2.getDenominator();

                int Num1 = this.numerator;
                int Num2 = fr2.getNumerator();

                Num1 = Num1 * Den2;
                Num2 = Num2 * Den1;

                Den1 = Den1 * Den2;
                Den2 = Den1;
                if (Num1 > Num2)
                {
                    return " > ";
                }
                else if (Num1 < Num2)
                {
                    return " < ";
                }
                else
                    return " = ";
            }
        }
    }
}

