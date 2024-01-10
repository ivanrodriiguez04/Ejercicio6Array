using Ejercicio6Array.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones
    /// irodhan -> 09/01/2024
    /// </summary>
    internal class OperacionalesImplementacion : OperacionalesInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            listaClienteAntigua.Add(nuevoCliente);
        }

        /// <summary>
        /// Metodo que pide al usuario la informacion necesaria para crear un nuevo cliente
        /// irodhan -> 10/01/2024
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente() 
        { 
            ClienteDto cliente = new ClienteDto();
            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del cliente: ");
            cliente.EdadCliente = Convert.ToInt32(Console.ReadLine());
            return cliente;
        }

        public void ordenarListaCLiente(List<ClienteDto> listaClienteAtigua)
        {
            throw new NotImplementedException();
        }
    }
}
