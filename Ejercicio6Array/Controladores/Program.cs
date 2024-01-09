using Ejercicio6Array.Dtos;
using Ejercicio6Array.Servicios;

namespace Ejercicio6Array.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 09/01/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 09/01/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            OperacionalesInterfaz oI = new OperacionalesImplementacion();
            MenuInterfaz mI = new MenuImplementacion();

            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mI.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Ha seleccionado la opcion 0");
                        Console.WriteLine("Se va a cerrar la app");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Ha seleccionado la opcion 1");
                        oI.darAltaCliente(listaCliente);
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado la opcion 2");
                        oI.ordenarListaCLiente(listaCliente);
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion del menu");
                        break;
                }
            }

        }
    }
}
