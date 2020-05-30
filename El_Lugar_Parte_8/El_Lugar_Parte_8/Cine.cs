using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lugar_Parte_8
{
    public class Cine : Locales
    {
        private int Rooms { get; set; }

        public Cine(int Rooms, string Name, int Number, string Schedules) : base(Name, Number, Schedules)
        {
            this.Rooms = Rooms;
        }

        public int room()
        {
            return Rooms;
        }
    }

}
