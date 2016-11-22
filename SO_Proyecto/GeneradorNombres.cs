using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO_Proyecto
{
    //se crea esta clase para generar nombres al azar.
    public static class GeneradorNombres
    {
        //diccionario de nombres
        private static List<string> Nombres = new List<string>
                {
                            "Sandra", "Lucas", "Luis", "Ester","Hugo", "Álvaro", "Adrián",
                            "Marcela", "Esteban", "Ericka", "Lorena", "Carlos", "Juan", "Diego",
                            "Sergio", "Iván", "Miguel", "Sonia", "Sarah", "Tomás", "Lidia"
                };
        //diccionario de apellidos
        private static List<string> Apellidos = new List<string>
                {
                            "Torres", "Sanchez", "Arias", "Perez", "Campos", "Carrasco", "Carvajal",
                            "Alvarado", "Watson", "Rodriguez", "Gonzalez", "Jimenez", "Rojas",
                            "Castro", "Escobar", "Ledesma", "León", "Robles", "Olmedo", "Ríos", "Salazar"
                };
        
        private static Random _rand = new Random();

        //usando el objeto Random se genera un indice al azar para el nombre y el apellido
        //se retornan ambos concatenados.
        public static string GenerarNombreCompleto()
        {
            var idxNombre = _rand.Next(Nombres.Count - 1);
            var idxApellido = _rand.Next(Apellidos.Count - 1);

            return Nombres[idxNombre] + " " + Apellidos[idxApellido];
        }
    }
}
