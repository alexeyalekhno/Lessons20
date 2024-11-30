using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Сircumference;
            double a = myDelegate(1.17);
            Console.WriteLine(a);

            myDelegate = SquareCircle;
            a = myDelegate(1.17);
            Console.WriteLine(a);

            myDelegate = VolumeBall;
            a = myDelegate(1.17);
            Console.WriteLine(a);

            Console.ReadKey();        
        }

        static double Сircumference(double r)
        {
            double d = 2 * Math.PI * r;
            return d;
        }

        static double SquareCircle(double r)
        { 
        double s = Math.PI * Math.Pow((double)r, 2);
            return s;
        }

        static double VolumeBall(double r)
        { 
        double v = ((4/3) * (Math.PI)) * (Math.Pow((double)r, 3));
            return v;
        }



    }
}
