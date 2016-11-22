using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_Proyecto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Datos datos = new Datos();
            Semaphore semaforo = new Semaphore(1, 1);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1(datos);

            var proceso1 = new ProcesoCajero(1, semaforo, datos, form1);
            var proceso2 = new ProcesoCajero(2, semaforo, datos, form1);
            var proceso3 = new ProcesoCajero(3, semaforo, datos, form1);
            var procesoFila = new ProcesoFila(semaforo, datos, form1);

            proceso1.Start();
            proceso2.Start();
            proceso3.Start();
            procesoFila.Start();

            Application.Run(form1);
        }
    }
}
