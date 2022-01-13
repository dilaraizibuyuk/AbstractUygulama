using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractUygulama
{
    abstract class Mobilya //abstractan obje tanımlanmaz fakat türetilmiş sınıflardan tanımlanabilir
    {
        public string renk;
        abstract public void ozellikyaz();//bildirim
    }
    class kanepe : Mobilya
    {
        public string kumas;

        public override void ozellikyaz()
        {
            Console.WriteLine("Kanepenin özellikleri:");
            Console.WriteLine("Renk:{0}",renk);
            Console.WriteLine("Kumaş:{0}",kumas);
        }
    }

    class masa:Mobilya
    {
        public string malzeme;

        public override void ozellikyaz()
        {
            Console.WriteLine("Masanın özellikleri");
            Console.WriteLine("Renk:{0}", renk);
            Console.WriteLine("Malzeme:{0}", malzeme);

        }
    }
}
