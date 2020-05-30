using El_Lugar_Parte_8.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 appform = new Form1();
            Tienda_Controlador t_control = new Tienda_Controlador(appform);
            Cine_Controlador c_control = new Cine_Controlador(appform);
            Restaurante_Controlador rest_control = new Restaurante_Controlador(appform);
            Recreacion_Controlador rec_control = new Recreacion_Controlador(appform);
            Locales_Controlador L_cotrol = new Locales_Controlador(appform);

            Application.Run(appform);
        }
    }
}
