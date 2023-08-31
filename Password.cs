using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyurtma
{
    internal class Password
    {
        private  int Parol=12345;

        public void InPassword()
        {
            do
            {
                Console.Write("Dasturdan foydalanish Paroli\n Enter Password: ");
                int pass = int.Parse(Console.ReadLine());

                if(pass == Parol)
                {
                    Console.Clear();
                    Console.WriteLine("Kirish tasdiqlandi");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Parol xato kiritildi qayta kiriting");
                }
            }while(true);
        }

    }
}
