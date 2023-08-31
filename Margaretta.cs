using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace buyurtma
{
    internal class Margaretta:Pizza
    {
        public Margaretta(string name, int minut)
            :base(name, minut) { }
        public override void Dough()
        {
            Console.WriteLine($"Xamiri yoyilyapti: {Name}");
            Timer(10);// tayyor bulish vaqti
            Console.WriteLine("Tayyorlandi!!!");
        }
        public override void IngredientsPriparation()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Maxsulotlar tayorlanmoqda :{Name} ga");
            Timer(12);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public override void Cooking()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Cooking: {Name}");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public override void Cutting()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Cutting: {Name}");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public override void Packing()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Packing: {Name}");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public void DesplayInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Size:{Size}");
            Console.WriteLine($"Total minut:{Minut}");

        }
       
    }
}
