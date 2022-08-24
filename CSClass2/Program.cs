using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> WantedString = new Wanted<string>("String");
            Wanted<int> WantedInt = new Wanted<int>(12345);
            Wanted<double> WantedDouble = new Wanted<double>(12.345);

            Console.WriteLine(WantedString.Value);
            Console.WriteLine(WantedInt.Value);
            Console.WriteLine(WantedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;
        }
    }
}
