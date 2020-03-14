using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase Hamburguesa, un tipo de alimento. Implementa la interfaz IAlimento
    /// </summary>
    public class Hamburguesa : IAlimento
    {
        /// <summary>
        /// Propiedad de la clase. Realiza una implementación del get para mostrar el tipo de hamburguesa
        /// </summary>
        public string NombreAlimento {
            get
            {
                return "Hamburguesa " + TipoDeHamburguesa;
            }
        }

        /// <summary>
        /// nueva propiedad de la clase. No se encuentra en la Interfaz, se usa nueva para almacenar el tipo de hamburguesa
        /// Esta propiedad se asigna cuando se instancia la clase
        /// </summary>
        public string TipoDeHamburguesa { get; set; }

        /// <summary>
        /// Implementación del metodo de la interfaz.
        /// </summary>
        public void Preparando()
        {
            Console.WriteLine("Preparando " + NombreAlimento);
        }
    }
}
