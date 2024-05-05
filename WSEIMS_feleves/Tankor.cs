using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_feleves
{
    public class Tankor
    {
        class TankorElem
        {
            public Hallgato Jelenlegi { get; set; }
            public TankorElem Következő { get; set; }
        }

        private TankorElem fej;

        private int maxletszam = 4;
        private int jelenlegiletszam = 0;


        public void Beszuras(Hallgato ujhallgato)
        {

            TankorElem e;
            TankorElem p;
            if (jelenlegiletszam < maxletszam)
            {
                TankorElem uj = new TankorElem();
                if (fej == null)
                {
                    uj.Jelenlegi = ujhallgato;
                    uj.Következő = fej;
                    fej = uj;
                    jelenlegiletszam += 1;

                }
                else
                {
                    p = fej;
                    e = null;
                    int jelenlegiszam = int.Parse(p.Jelenlegi.NeptunKód.Where(char.IsDigit).ToString());
                    int ujjhalneptun = int.Parse(ujhallgato.NeptunKód.Where(char.IsDigit).ToString());
                    while (p != null && jelenlegiszam < ujjhalneptun)
                    {
                        e = p;
                        p = p.Következő;
                        jelenlegiszam = int.Parse(p.Jelenlegi.NeptunKód.Where(char.IsDigit).ToString());
                        ujjhalneptun = int.Parse(ujhallgato.NeptunKód.Where(char.IsDigit).ToString());
                    }
                    if (p == null)
                    {
                        uj.Következő = null; e.Következő = uj;
                        jelenlegiletszam += 1;
                    }
                    else
                    {
                        uj.Következő = p; e.Következő = uj;
                        jelenlegiletszam += 1;
                    }
                }

                Console.WriteLine("Sikeres felvétel");
            }
            else
            {
                throw new Exception("A tankör megtelt!");
            }


        }
        public void Bejaras()
        {
            TankorElem p = fej;
            while (p != null)
            {
                Console.WriteLine(p.Jelenlegi.Név + ",");
                p = p.Következő;
            }
        }
        public bool Keres(string név)
        {
            TankorElem p = fej;
            while (p.Jelenlegi.Név != név)
            {
                p = p.Következő;
            }
            if (p.Jelenlegi.Név==név)
            {
                return true;
            }else
            return false;
        }

        public int Fabeillesztoszam()
        {
            int szam = 0;
            TankorElem p = fej;
             while (p.Következő != null)
             {
                szam = int.Parse((p.Következő.Jelenlegi.NeptunKód).Substring(2, 3));
                p = p.Következő;
             }
            return szam;
        }
        public void Kiiratkoztatas(string kiiratkozo)
        {

            TankorElem e = null;
            TankorElem p = fej;


            while (p != null && p.Jelenlegi.Név != kiiratkozo)
            {
                e = p;
                p = p.Következő;
            }
            if (p != null)
            {
                if (e == null)
                {
                    fej = p.Következő;
                }
                else
                {
                    e.Következő = p.Következő;
                }
            }
            else Console.WriteLine("Hallgató nem található");

        }
    }
}
