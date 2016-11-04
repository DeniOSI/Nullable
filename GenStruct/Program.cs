using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a;
            a = null;
            Console.WriteLine(a);
            Nullable<int> nb;
            nb = 32;
            Console.WriteLine(nb);
            Console.ReadKey();
        }
    }
}
