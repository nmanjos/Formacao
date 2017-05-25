using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoFinal
{

    static class Program
    {
        public static BDTickets TicketDB = new BDTickets();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTickets());
        }
        private static bool FirstRun()
        {
            bool result = false;
            ;
            if (TicketDB.ProcuraPerfil(000000000) == null)
            {
                result = true;

                TicketDB.InsereTecnico(new Tecnico("ADMIN",000000000,"000000000",null,null,true));
            }

            return result;
        }
    }
}
