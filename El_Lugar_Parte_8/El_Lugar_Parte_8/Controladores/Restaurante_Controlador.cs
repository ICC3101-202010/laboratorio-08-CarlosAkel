using El_Lugar_Parte_8.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8.Controladores
{
    class Restaurante_Controlador
    {
        Form1 appform;
        List<Restaurante> rest = new List<Restaurante>();

        public Restaurante_Controlador(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.CreateNewRestaurant += OnCreateNewRestaurant;
            this.appform.GetRestaurant += OnGetRestaurant;
        }
        public bool OnCreateNewRestaurant(object source,Restaurant_EventArgs e)
        {
            foreach (Restaurante r in rest)
            {
                if(r.get_id() == e.id)
                {
                    return false;
                }
            }
            Restaurante TheRestaurant = new Restaurante(e.exclusive,e.name,e.id,e.schedules);
            rest.Add(TheRestaurant);
            return true;
        }
        public List<Restaurante> OnGetRestaurant(object source, EventArgs e)
        {
            return rest;
        }
    }
}
