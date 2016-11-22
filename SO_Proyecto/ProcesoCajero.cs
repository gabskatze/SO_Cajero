using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SO_Proyecto
{
    public class ProcesoCajero
    {
        public Thread MiHilo { get; set; }
        public int Id { get; set; }
        public Datos Datos { get; set; }
        public Semaphore Semaforo { get; set; }
        public Form1 MyForm { get; set; }
        
        private const int duracion = 5000;//duracion de proceso atendiendo una persona en cada caja

        public ProcesoCajero(int id, Semaphore semaforo, Datos datos, Form1 myForm)
        {
            Id = id;
            Semaforo = semaforo;
            Datos = datos;
            MyForm = myForm;
            MiHilo = new Thread(ThreadBody);
        }

        private void ThreadBody()
        {
            while (true)
            {
                //inicio de zona segura
                Semaforo.WaitOne();//se adquiere el permiso de entrar que lo da el semaforo
                var primero = Datos.Personas.FirstOrDefault();
                //Thread.Sleep(10);
                switch (Id)
                {
                    case 1:
                        Datos.Caja1 = primero;
                        break;
                    case 2:
                        Datos.Caja2 = primero;
                        break;
                    case 3:
                        Datos.Caja3 = primero;
                        break;
                }

                if (Datos.Personas.Any())
                {
                    Datos.Personas.RemoveAt(0);
                }
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
