using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _15._04
{
    internal class danni
    {
        private string ime_na_zakuska;
        private int broyka;
        private string pitieta;
        public string Ime_na_zakuska
        {
            get { return ime_na_zakuska; }
            set { ime_na_zakuska = value; }
        }
        public int Broyka
        {
            get { return broyka; }
            set { broyka = value; }
        }
        public void Izhod()
        {
            Console.WriteLine($"Ti dnes si ql {ime_na_zakuska} puti i si ql {broyka}.");
        }
        public void Izhod1()
        {

        }
        public string Pitieta
        { get { return pitieta; } 
        set { pitieta = value; } 
        }


    }
}
