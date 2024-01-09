using Ejercicio6Array.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Servicios
{
    /// <summary>
    /// Interfaz que llama al metodo de la implementacion
    /// irodhan -> 09/01/2024
    /// </summary>
    internal interface OperacionalesInterfaz
    {
        /// <summary>
        /// Metodo para dar el alta a los clientes
        /// irodhan -> 09/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua);
        /// <summary>
        /// Metodo para ordenar la lista de los clientes
        /// irodhan -> 09/01/2024
        /// </summary>
        /// <param name="listaClientesAtigua"></param>
        public void ordenarListaCLiente(List<ClienteDto> listaClienteAtigua);
    }
}
