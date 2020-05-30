using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lugar_Parte_8
{
    public class Locales
    {
        private string Name { get; set; }
        private int Number { get; set; }
        private string Schedules { get; set; }


        public Locales(string Name,int Number, string Schedules)
        {
            this.Name = Name;
            this.Number = Number;
            this.Schedules = Schedules;
        }
        public int get_id()
        {
            return Number;
        }
        public string get_Name2()
        {
            return Name;
        }
        public string get_Schedules2()
        {
            return Schedules;
        }

    }
}
