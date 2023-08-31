using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyurtma
{
    internal class Pizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Description { get; set; } =null;
        public string Ingredients { get; set; } = null;
        public int Minut { get; set; }

        public Pizza(string name,int minut) { Name = name; Minut = minut; }
        public Pizza(string name, decimal price, int size,  string description, string ingredients)
        {
            Name = name; Price = price; Size = size; Description = description; Ingredients = ingredients;
        }
        public virtual void Dough()
        {
            Console.WriteLine($"Xamiri yoyilyapti: {Name}");
            Timer(Minut);// tayyor bulish vaqti
            Console.WriteLine("Tayyorlandi!!!");
        }
        public virtual void IngredientsPriparation()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Maxsulotlar tayorlanmoqda :{Name} ga");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public virtual void Cooking()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Cooking: {Name}");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public virtual void Cutting()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Cutting: {Name}");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public virtual void Packing()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Packing: {Name}");
            Timer(Minut);
            Console.WriteLine("Tayyorlandi!!!");
        }
        public virtual void DesplayInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Size:{Size}");
            
        }
        public void Timer(int m)// umumiy vaqt funksiyasi
        {
            Console.WriteLine("Buyurtma vaqti.");
            for (int i = m; i >= 0; i--)
            {
                Console.WriteLine($"Tayyor bo'lishiga {i} secund qoldi");
                Thread.Sleep(m*500);
                Console.Clear();
            }
            Console.WriteLine("Bosqich tugadi.");
        }
    }
}
