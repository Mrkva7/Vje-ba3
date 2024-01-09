using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba3
{

    
    class Stablo
    {
        bool otpadajulistovi;
        string vrstaStabla;
        public bool Otpadajulistovi { get => otpadajulistovi; set => otpadajulistovi = value; }
        public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }

        public Stablo() { }

        public Stablo(bool otpadajulistovi)
        {
            this.otpadajulistovi = otpadajulistovi;
        }

        public override string ToString()
        {
            string  ispis = "Ovo stablo je:";
            if(otpadajulistovi)
            {
                ispis += "listopadno.";
            }
            else
            {
                ispis += "Zimzeleno.";
            }
                return ispis;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo();
            Stablo stablo2 = new Stablo(); 

            Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());  


            
            Console.ReadKey();


        }
    }
}
