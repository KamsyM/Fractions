using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Fraction(2,3);
            var work2 = new Fraction(1,4);
            Console.WriteLine(work);
            Console.WriteLine(work.MultiplyBy(work2));
            Console.ReadKey();
        }
    }

    public class Fraction
    {
        private int numerator;
        private int denominator;
        private int mixed_wholenumber;

        public Fraction(int numer, int denom)
        {
            numerator = numer;
            denominator = denom;
        }

        public Fraction Plus(Fraction a)
        {
            if (a.denominator == denominator)
            {
                int ans = a.numerator + numerator;
                int div = GreatestCommonDivisor(ans, denominator);
                int nume = ans / div;
                int deno = denominator / div;
                if (nume < deno)
                {
                    return new Fraction(nume ,deno);
                }

                else
                {
                    return (nume / deno) + "&" + (nume % deno) + "/" + deno;
                }
                
            }

            else
            {
                int lcm = determineLCM(a.denominator, denominator);
                int first = (lcm / a.denominator) * a.numerator;
                int second = (lcm / denominator) * numerator;
                int ans = first + second;
                int div = GreatestCommonDivisor(ans, lcm);
                int nume = ans / div;
                int deno = lcm / div;
                if (nume < deno)
                {
                    return new Fraction(nume, deno);
                }

                else
                {
                    return (nume / deno) + "&" + (nume % deno) + "/" + deno;
                }
                
            }
        }

        public string Minus(Fraction a)
        {
            if (a.denominator == denominator)
            {
                int ans = numerator - a.numerator ;
                int div = GreatestCommonDivisor(ans, denominator);
                int nume = ans / div;
                int deno = denominator / div;
                if (nume < deno)
                {
                    return nume + "/" + deno;
                }

                else
                {
                    return (nume / deno) + "&" + (nume % deno) + "/" + deno;
                }
                
            }

            else
            {
                int lcm = determineLCM(a.denominator, denominator);
                int first = (lcm / a.denominator) * a.numerator;
                int second = (lcm / denominator) * numerator;
                int ans = second - first;
                int div = GreatestCommonDivisor(ans, lcm);
                int nume = ans / div;
                int deno = lcm / div;
                if (nume < deno)
                {
                    return nume + "/" + deno;
                }

                else
                {
                    return (nume / deno) + "&" + (nume % deno) + "/" + deno;
                }
                
            }
        }

        public string MultiplyBy(Fraction a)
        {
            int top = numerator * a.numerator;
            int bottom = denominator * a.denominator;
            int div = GreatestCommonDivisor(top, bottom);
            int nume = top / div;
            int deno = bottom / div;
            if (nume < deno)
            {
                return nume + "/" + deno;
            }

            else
            {
                return (nume / deno) + "&" + (nume % deno) + "/" + deno;
            }
        }

        public string DivideBy(Fraction a)
        {
            int top = numerator * a.denominator;
            int bottom = denominator * a.numerator;
            int div = GreatestCommonDivisor(top, bottom);
            int nume = top / div;
            int deno = bottom / div;
            if (nume < deno)
            {
                return nume + "/" + deno;
            }

            else
            {
                return (nume / deno) + "&" + (nume % deno) + "/" + deno;
            }
            
        }

        public override string ToString()
        {
            return numerator.ToString()  + "/" + denominator.ToString();
        }

        public static int determineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num1 * num2;
        }

        public int GreatestCommonDivisor(int x, int y)

        {


            while (x != y)

            {

                if (x > y)

                    x = x - y;

                else

                    y = y - x;

            }

            // greatest common diviser will be x

            return x;
        }

        }
    }
