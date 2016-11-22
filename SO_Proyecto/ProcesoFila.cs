using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SO_Proyecto
{
    public class ProcesoFila
    {
        public Thread MiHilo { get; set; }
        public Datos Datos { get; set; }
        public Semaphore Semaforo { get; set; }
        public Form1 MyForm { get; set; }

        private const int duracion = 3000;//duracion de entrada de personas a la fila

        public ProcesoFila(Semaphore semaforo, Datos datos, Form1 myForm)
        {
            Semaforo = semaforo;
            Datos = datos;
            MyForm = myForm;
            MiHilo = new Thread(ThreadBody);
        }

        private void ThreadBody()
        {
            while (true)
            {
                Semaforo.WaitOne(); //inicio de zona segura. Solo se puede accesar un hilo a la vez
                string nombre = GeneradorNombres.GenerarNombreCompleto();
                Datos.Personas.Add(nombre);
                Semaforo.Release();//fin de zona segura

                Thread.Sleep(duracion);
            }
        }

        public void Start()
        {
            MiHilo.Start();
        }
    }
}
