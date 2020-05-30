using El_Lugar_Parte_8.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8.Controladores
{
    class Cine_Controlador
    {
        Form1 appform;
        Locales_Controlador localId;
        List<Cine> owner = new List<Cine>();



        public Cine_Controlador(Form appform)
        {
            this.appform = appform as Form1;
            this.localId = localId as Locales_Controlador;
            this.appform.CreateNewCinema += OnCreateNewCinema;
            this.appform.GetCine += OnGetCine;
            //this.localId.CineID += OnCineID;
        }

        public bool OnCreateNewCinema(object source,Cinea_EventArgs e)
        {
            foreach(Cine cin in owner)
            {
                if(e.id == cin.get_id())
                {

                    return false;
                }
            }
            Cine cine = new Cine(e.rooms,e.name,e.id,e.schedules);
            owner.Add(cine);
            return true;
        }
        public List<int> OnCineID(object source, EventArgs e)
        {
            List<int> cineid = new List<int>();
            if(owner.Count == 0)
            {
                return null;
            }
            foreach (Cine i in owner)
            {
                cineid.Add(i.get_id());
            }

            return cineid;
        }

        public List<Cine> OnGetCine(object source, EventArgs e)
        {
            return owner;
        }
    }
}
