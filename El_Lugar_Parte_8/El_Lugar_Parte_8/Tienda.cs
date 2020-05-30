using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lugar_Parte_8
{
    public class Tienda : Locales
    {
        //private List<string> Categories = new List<string>();
        private List<string> Categories = new List<string>();


        public Tienda(List<string> categoriaes,string Name,int Number,string Schedules):base(Name, Number, Schedules)
        {
            this.Categories = categoriaes;
        }
        public List<string> get_cat()
        {
            return Categories;
        }

        public List<string> categoriaes { get => categoriaes; set => categoriaes = value; }
    }

}
