using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SO_Proyecto
{
    class hiloReporte
    {
        public Thread MiHilo { get; set; }
        public Datos Datos { get; set; }
        public Form2 form2 { get; set; }

        private const int duracion = 5000;
        public hiloReporte(Datos datos)
        {
            Datos = datos;
            form2 = new Form2();
            form2.Show();
            MiHilo = new Thread(ThreadBody);
        }

        private void ThreadBody()
        {
           while (true)
            {
                form2.SetTextCaja1(Datos.Caja1);
                form2.SetTextCaja2(Datos.Caja2);
                form2.SetTextCaja3(Datos.Caja3);
                Thread.Sleep(duracion);
            }
        }

        public void Start()
        {
            MiHilo.Start();
        }



    }
}
