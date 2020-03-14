using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase Pizza. Implementa la interfaz IAlimento
    /// </summary>
    class Pizza : IAlimento
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="Ingrediente">Ingrediente de la pizza, se almacena para usarse como nombre del alimento</param>
        public Pizza(string Ingrediente)
        {
            NombreAlimento = "Pizza de " + Ingrediente;
        }

        /// <summary>
        /// Propiedad que viene de la interfaz IAlimento y almacena el nombre del alimento
        /// </summary>
        public string NombreAlimento { get; private set; }

        /// <summary>
        /// Implementación del método Preparando de la Interfaz
        /// </summary>
        public void Preparando()
        {
            Console.WriteLine("Preparando " + NombreAlimento);
        }
    }
}
