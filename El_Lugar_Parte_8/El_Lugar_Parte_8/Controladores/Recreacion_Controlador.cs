using El_Lugar_Parte_8.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8.Controladores
{
    class Recreacion_Controlador
    {
        Form1 appform;

        List<Recreacion> rec = new List<Recreacion>();
        public Recreacion_Controlador(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.CreateRecreation += OnCreateRecreation;
            this.appform.GetRecreation += OnGetRecreation;
        }

        public bool OnCreateRecreation(object source,Recreation_EventArgs e)
        {
            foreach(Recreacion item in rec)
            {
                if(e.id == item.get_id())
                {
                    return false;
                }
            }
            Recreacion play = new Recreacion(e.name,e.id,e.schedules);
            rec.Add(play);
            return true;
        }
        public List<Recreacion> OnGetRecreation(object source,EventArgs e)
        {
            return rec;
        }
}
}
