using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartPro_30_10_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add = 1;

            Console.Write("Kaç adet kullanıcı kaydı yapılacak: ");
            add = int.Parse(Console.ReadLine());

            string[] names = new string[add];
            string[] surnames = new string[add];

            for (int i = 0; i < add; i++)
            {
                Console.Write("{0}. İsim: ",(i+1));
                names[i] = Console.ReadLine();

                Console.Write("{0}. Soyisim: ", (i + 1));
                surnames[i] = Console.ReadLine();

            }
            Console.Write("\nYazdırmak için bir tuşa basınız.\n");
            Console.ReadKey();

            for (int i = 0;i < add;i++) 
            {
               Console.Write("{0}. kişi {1} {2}\n",(i+1), names[i], surnames[i]);
            }
                
            
            
            Console.ReadKey();
        }
    }
}
