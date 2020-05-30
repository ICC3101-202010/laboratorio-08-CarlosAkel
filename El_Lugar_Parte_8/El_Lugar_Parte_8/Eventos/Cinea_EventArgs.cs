using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lugar_Parte_8.Eventos
{
    public class Cinea_EventArgs : EventArgs
    {

        public string name { get; set; }
        public int id { get; set; }
        public string schedules { get; set; }
        public int rooms { get; set; }

    }
}
