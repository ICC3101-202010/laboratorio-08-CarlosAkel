﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lugar_Parte_8.Eventos
{
    public class Shop_EventArgs : EventArgs
    {
        public string name { get; set; }
        public int id { get; set; }
        public string schedules { get; set; }
        public List<string> categories { get; set; }
    }
}
