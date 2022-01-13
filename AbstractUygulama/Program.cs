using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            kanepe knp1 = new kanepe();
            masa calisma_masasi = new masa();
            knp1.renk = "pembe";
            knp1.kumas = "Deri";
            calisma_masasi.renk = "Siyah";
            calisma_masasi.malzeme = "Ahşap";
            knp1.ozellikyaz();
            calisma_masasi.ozellikyaz();
            Console.ReadKey();
        }
    }
}
