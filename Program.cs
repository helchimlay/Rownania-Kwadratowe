using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RownanieKwadratowe
    {
        public float a, b, c;
        public RownanieKwadratowe(float _a, float _b, float _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        float Delta()
        {
            return (b * b) - (4 * a * c);
        }

        public List<float> Rozwiazania()
        {

            if (Ilosc_rozwiazan() == 1)
            {
                return new List<float> { -(b / (2 * a)) };
            }
            else if (Ilosc_rozwiazan() == 2) return Oblicz_xs();
            return null;

        }

        public float Ilosc_rozwiazan()
        {
            if (Delta() > 0) return 2;
            else if (Delta() == 0) return 1;
            else return 0;
        }

        List<float> Oblicz_xs()
        {
            float x1 = ((float)(b * (-1) - Math.Sqrt(Delta())) / (2 * a));
            float x2 = ((float)(b * (-1) + Math.Sqrt(Delta())) / (2 * a));
            return new List<float> {x1,x2};
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float wartosc_a=0, wartosc_b=0, wartosc_c=0;
            Console.WriteLine("Podaj a");
            wartosc_a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            wartosc_b = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            wartosc_c = float.Parse(Console.ReadLine());
            RownanieKwadratowe r1 = new RownanieKwadratowe(wartosc_a,wartosc_b,wartosc_c);

            Console.WriteLine("Rozwiazania: ");
            if(r1.Ilosc_rozwiazan() == 1)
            {
                Console.WriteLine("x = " + r1.Rozwiazania()[0]);
            }
            else if(r1.Ilosc_rozwiazan() == 2)
            {
                Console.WriteLine("X1 = "+r1.Rozwiazania()[0]);
                Console.WriteLine("X2 = "+r1.Rozwiazania()[1]);
            }
            else
                Console.WriteLine("Brak rozwiazan!");



            Console.ReadKey();
        }
    }
}
