using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_feleves
{
    public class Hallgato :IHallgato
    {
         public int Terhelés { get; set; }
            public int Kapacitás { get; set; }
            public string Név { get; set; }
            public string Lakhely { get; set; }
            public string NeptunKód { get; set; }
            public List<Targy> Tárgyak { get; set; }


            public Hallgato(string Név, string Lakhely)
            {
                Random rnd = new Random();
                this.Név = Név;
                this.Lakhely = Lakhely;
                this.Terhelés = 0;
                this.NeptunKód = NeptunKódGeneralas();
                this.Kapacitás = rnd.Next(0, 999);
                this.Tárgyak = new List<Targy>();
            }
            private string NeptunKódGeneralas() //Works
            {
                string NeptunKod = null;
                Random rnd = new Random();
                if (0 == rnd.Next(0, 1))
                {
                    NeptunKod += "F-";
                }
                else { NeptunKod += "N-"; }

                NeptunKod += rnd.Next(100, 999);
                for (int i = 0; i < 2; i++)
                {
                    NeptunKod += ((char)rnd.Next('a', 'z' + 1)).ToString().ToUpper();
                }
                return NeptunKod;
            }


            public string Fogyasztás(int óra)
            {
                return Név + "nevű hallgató " + óra + " óra alatt " + (óra * 25) + " dl kávét fogyasztott és " + (óra * 2) + " alkalommal esett pánikba.";
            }

            public void Lefoglalás(int óra)
            {
                Terhelés += óra;
            }

            public int Teljesítmény()
            {
                return this.Terhelés;
            }

            public bool VaneMégKapacitás()
            {
                if (Kapacitás == Terhelés) { return false; }
                else { return true; }
            }

            public int CompareTo(IHallgato other)
            {
                return 0;
            }
        }
}
