using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del menu
    /// irodhan -> 09/01/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion=0;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Dar alta nuevo cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("Introduzca la opcion deseada:");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
