using El_Lugar_Parte_8.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8.Controladores
{
    class Tienda_Controlador
    {
        Form1 appform;
        List<Tienda> Shop = new List<Tienda>();

        public Tienda_Controlador(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.CreateNewShop += OnCreateNewShop;
            this.appform.GetShop += OnGetShop;
        }
        public bool OnCreateNewShop(object source,Shop_EventArgs e)
        {
            if(Shop.Count > 0)
            {
                foreach (Tienda tien in Shop)
                {
                    if (e.id == tien.get_id())
                    {
                        return false;
                    }
                }
            }

            Tienda shopi = new Tienda(e.categories,e.name,e.id,e.schedules);

            Shop.Add(shopi);

            return true;
        }
        public List<Tienda> OnGetShop(object source, EventArgs e)
        {
            
            return Shop;
        }
    }
}
