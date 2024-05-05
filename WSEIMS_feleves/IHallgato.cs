using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_feleves
{
    public interface IHallgato : IComparable<IHallgato>
    {
        string Név { get; set; }
        string NeptunKód { get; set; }
        string Lakhely { get; set; }
        List<Targy> Tárgyak { get; set; }

        string Fogyasztás(int óra);
        void Lefoglalás(int óra);
        int Teljesítmény();
        bool VaneMégKapacitás();
    }
}
