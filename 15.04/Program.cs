using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            danni A = new danni();
            Console.Write("Kakvo qde dnes?");
            A.Ime_na_zakuska=Console.ReadLine();
            Console.Write("Kolko puti yade?");
            A.Broyka=int.Parse(Console.ReadLine());
            A.Izhod();
            A.Izhod1();
            if (A.Broyka > 5)
            {
                Console.WriteLine(2 * A.Broyka);
            }
            else
            {
                Console.WriteLine("Broykata ti e po-malka ot 5.");
            }
            Console.WriteLine("Pil li si neshto dnes?");
            A.Pitieta = Console.ReadLine();
            if (A.Pitieta=="Ne")
            {
                Console.WriteLine("Lek den!");
            }
            if (A.Pitieta == "Da")
            {
                Console.WriteLine("Kakvo si pil: izberi cifra ot 0-3");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Ti si pil Martini"); 
                }
                if (a == 1)
                {
                    Console.WriteLine("Ti si pil Vodka");
                }
                if (a == 2)
                {
                    Console.WriteLine("Ti si pil Viski");
                }
                if (a == 3)
                {
                    Console.WriteLine("Ti si pil Voda");
                }
                else 
                {
                    Console.WriteLine("Nqma takova v menuto");
                }
            }
        }
    }
}
