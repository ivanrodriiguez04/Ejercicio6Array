using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Dtos
{
    /// <summary>
    /// Clase que contiene toda la informacion necesaria del cliente
    /// irodhan -> 09/01/2024
    /// </summary>
    internal class ClienteDto
    {
        //Atributos
        long idCliente;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string nombreCompleto = "aaaaa";
        int edadCliente = 0;

        //Getters & Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        //Constructores
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompleto, int edadCliente)
        {
            this.IdCliente = idCliente;
            this.NombreCliente = nombreCliente;
            this.ApellidosCliente = apellidosCliente;
            this.NombreCompleto = nombreCliente+" "+apellidosCliente;
            this.EdadCliente = edadCliente;
        }
        
        //ToString
        override
        public string ToString()
        {
            string concatenacion = "Nombre completo: " + this.nombreCompleto + "\n" + "Edad: " + this.edadCliente;
            return concatenacion;
        }

    }
}
