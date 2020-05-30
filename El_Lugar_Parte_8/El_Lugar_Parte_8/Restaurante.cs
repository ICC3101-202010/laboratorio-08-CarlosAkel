using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lugar_Parte_8
{
    public class Restaurante : Locales
    {
        private bool Exclusive { get; set; }
        public Restaurante(bool Exclusive, string Name, int Number, string Schedules) : base(Name, Number, Schedules)
        {
            this.Exclusive = Exclusive; 
        }
        public bool Ex()
        {
            return Exclusive;
        }
    }
}
