using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.kenar uzunluğunu giriniz");
            double kenar1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.kenar uzunluğunu giriniz");
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            double kareleritoplami = Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2);
            double hipoLong = Math.Sqrt(kareleritoplami);
            Console.WriteLine("hipotenüs uzunluğu: {0}", hipoLong);
            Console.ReadKey();
        }
    }
}
