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
            if (FirstRun()) MessageBox.Show("This is your First Run, please fill all aux tables before deploing the app");
            Application.Run(new FormTickets());

        }
        private static bool FirstRun()
        {
            bool result = false;
            
            if (TicketDB.ProcuraPerfil(000000000) == null)
            {
                result = true;
                Habilitacao hablit = new Habilitacao("Licenciatura", 6);
                TicketDB.InsereHabilitacao(hablit);

                if (TicketDB.InsereTecnico(new Tecnico("ADMIN", 000000000, "000000000",hablit, null, true ,true)))
                {
                    MessageBox.Show("Utilizador de Administração criado, altere a password assim que possivel ");
                }   
            }

            return result;
        }
    }
}
