using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_feleves
{
    public class HallgatoKezeloModul
    {
        public void Start()
        {
            Fa fa = new Fa();
            Tankor Matek = new Tankor();
            Tankor Prog1 = new Tankor();
            Tankor Prog2 = new Tankor();
            Tankor Adatb = new Tankor();

            Targy targy1 = new Targy("Adatb", 100);
            Targy targy2 = new Targy("Prog1", 200);
            Targy targy3 = new Targy("Prog2", 300);
            Targy targy4 = new Targy("Matek1", 400);
            Targy targy5 = new Targy("Matek2", 500);

            Hallgato hallgato1 = new Hallgato("Emese","Budapest");
            Hallgato hallgato2 = new Hallgato("Péter", "Szerda");
            Hallgato hallgato3 = new Hallgato("Roland", "Székesfehérvár");
            Hallgato hallgato4 = new Hallgato("Dániel", "Miskolc");
            Hallgato hallgato5 = new Hallgato("Attile", "Kecskemét");

            hallgato1.Tárgyak.Add(targy1);
            hallgato1.Tárgyak.Add(targy2);
            hallgato1.Tárgyak.Add(targy4);

            hallgato2.Tárgyak.Add(targy4);
            hallgato2.Tárgyak.Add(targy3);
            hallgato2.Tárgyak.Add(targy5);

            hallgato3.Tárgyak.Add(targy3);
            hallgato3.Tárgyak.Add(targy2);
            hallgato3.Tárgyak.Add(targy4);

            hallgato4.Tárgyak.Add(targy5);
            hallgato4.Tárgyak.Add(targy2);
            hallgato4.Tárgyak.Add(targy3);

            hallgato5.Tárgyak.Add(targy3);
            hallgato5.Tárgyak.Add(targy1);
            hallgato5.Tárgyak.Add(targy5);

            Matek.Beszuras(hallgato1);
            Matek.Beszuras(hallgato2);

            Prog1.Beszuras(hallgato3);
            Prog1.Beszuras(hallgato5);

            Prog2.Beszuras(hallgato5);
            Prog2.Beszuras(hallgato4);

            Adatb.Beszuras(hallgato3);
            Adatb.Beszuras(hallgato2);

            fa.Add(Matek, Matek.Fabeillesztoszam());
            fa.Add(Prog1, Prog1.Fabeillesztoszam());
            fa.Add(Prog2, Prog2.Fabeillesztoszam());
            fa.Add(Adatb, Adatb.Fabeillesztoszam());





            Menu();
        }
        
        private void Menu()
        {

        
        }

    }
}
