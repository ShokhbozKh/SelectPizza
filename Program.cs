namespace buyurtma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password parol = new Password();
            parol.InPassword();
            Console.ReadKey();

            Menyu.ShowMenyu();

            int select = SelectPizza();
            switch(select)
            {    
                case 1:
                    Pizza pizza1= new Pizza("Big pizza",2);
                    pizza1.Dough();
                    pizza1.Cooking();
                    pizza1.Cutting();
                    pizza1.Packing();
                    pizza1.DesplayInfo();

                    break;
                case 2:
                    Pizza pizza2 = new Peppironi("Peppironi",3);
                    pizza2.Dough();
                    pizza2.Cooking();
                    pizza2.Cutting();
                    pizza2.Packing();
                    pizza2.DesplayInfo();

                    break;
                case 3:
                    Pizza pizza3 = new Margaretta("Margaretta",2);
                    pizza3.Dough();
                    pizza3.Cooking();
                    pizza3.Cutting();
                    pizza3.Packing();
                    pizza3.DesplayInfo();
                    break;
                case 0:
                    Console.WriteLine("Dastur Tugadi") ; return;
                default:
                    Console.WriteLine("Bunday pitsa mavjud emas");
                    break;

            }
          
        }
        static int SelectPizza()
        {
            Console.Write("Tanlash-> ");
            int select = int.Parse(Console.ReadLine());
            return select;
        }
       
    }
}