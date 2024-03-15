using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = CalculateCircumference;
            //double r = myDelegate(5);
            //Console.WriteLine(r);
            //myDelegate = CalculateArea;
            //r = myDelegate(5);
            //Console.WriteLine(r);
            //myDelegate = CalculateVolume;
            //r = myDelegate(5);
            //Console.WriteLine(r);

            MyDelegate myDelegate = CalculateCircumference;
            myDelegate += CalculateArea;
            myDelegate += CalculateVolume;
            myDelegate(5.0);
            Console.ReadKey();
        }
        static double CalculateCircumference(double radius)
        {
            double r = 2 * Math.PI * radius;
            Console.WriteLine(r);
            return r;
        }

        static double CalculateArea(double radius)
        {
            double r = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(r);
            return r;
        }        
        static double CalculateVolume(double radius)
        {
            double r = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine(r);
            return r;
        }
    }
}
            