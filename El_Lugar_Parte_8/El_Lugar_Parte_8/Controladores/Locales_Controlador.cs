using El_Lugar_Parte_8.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8.Controladores
{
    class Locales_Controlador
    {
        List<int> Allid = new List<int>();
        Form1 appform;
        Cine_Controlador cine;

        //public delegate List<int> CineEventHandler(object source,EventArgs e);
        //public event CineEventHandler CineID;

        public Locales_Controlador(Form appform)
        {
            this.appform = appform as Form1;
            //this.appform.SaveIdCine += OnSaveIdCine;
            this.appform.GetAllId += OnGetAllId;
            this.appform.IdCheck += OnIdCheck;

        }


        /*public void OnSaveIdCine(object source,EventArgs e)
        {
            List<int> cid = CineID(this,new EventArgs());
            foreach(int item in cid)
            {
                if(Allid.Contains(item) == false)
                {
                    Allid.Add(item);
                }
            }
        }*/
        public bool OnIdCheck(object source,Local_EventArgs e)
        {
            foreach(int item in Allid)
            {
                if(e.id == item)
                {
                    return false;
                }
            }
            Allid.Add(e.id);
            return true;
        }

        public List<int> OnGetAllId(object source, EventArgs e)
        {
            return Allid;
        }



    }
}
