using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SO_Proyecto
{
    public class Datos
    {
        
        public List<string> Personas { get; set; }//lista de personas en la fila de espera

        public string Caja1 { get; set; }//persona que esta siendo atendida en la Caja 1
        public string Caja2 { get; set; }//persona que esta siendo atendida en la Caja 2
        public string Caja3 { get; set; }//persona que esta siendo atendida en la Caja 3


        //en este constructor se generan 10 nombres al azar para inicializar la fila.
        public Datos()
        {
            Personas = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Personas.Add(GeneradorNombres.GenerarNombreCompleto());
            }
        }   

    }
}
