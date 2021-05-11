using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.46
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            double v = a * b * c;
            double s = 2 * (a * b + a * c);
            Console.WriteLine("Объём=" + v);
            Console.WriteLine("Площадь бок поверхности=" +s);
            Console.ReadKey();





        }
    }
}
