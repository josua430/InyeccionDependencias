using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Interfaz para alimento. Usada para implementar clases
    /// </summary>
    public interface IAlimento
    {
        /// <summary>
        /// Propiedad de interfaz que tendrá el nombre del alimento
        /// </summary>
        string NombreAlimento { get; }

        /// <summary>
        /// Método para indicar que se está preparando un alimento
        /// </summary>
        void Preparando();
    }
}
