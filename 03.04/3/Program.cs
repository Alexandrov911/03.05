using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.7
            for (int i = 1; i < 21; i++)
                Console.WriteLine(i + " " + Convert.ToDouble(i * 22.04));
            Console.ReadKey();
        }
    }
}
