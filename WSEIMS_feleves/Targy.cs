using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_feleves
{
    public class Targy
    {
        public string TargyNeve { get; set; }
        public int FelkészülésiÓra { get; set; }
        public Targy(string targyNeve, int felkészülésiÓra)
        {
            TargyNeve = targyNeve;
            FelkészülésiÓra = felkészülésiÓra;
        }
    }
}
