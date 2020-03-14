using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase persona, usa la interfaz IAlimento, no una clase base. Uso Inyeccion de dependencia, depende de una interfaz
    /// no de una clase en particular. No Implementa ninguna clase base y no crea objetos.
    /// </summary>
    class Persona
    {
        /// <summary>
        /// La clase usa la interfaz IAlimento para referenciar que puede usar cualquier tipo de alimento
        /// </summary>
        IAlimento _Alimento;

        /// <summary>
        /// Constructor de la clase, recibe una interfaz IAlimento, no uno en particular
        /// </summary>
        /// <param name="miAlimento">Interfaz alimento</param>
        public Persona(IAlimento miAlimento)
        {
            _Alimento = miAlimento;
        }

        /// <summary>
        /// Método comer que muestra que alimento esta comiendo
        /// </summary>
        public void Comer()
        {
            _Alimento.Preparando();
            Console.WriteLine("Me encuentro comiendo " + _Alimento.NombreAlimento);
        }

    }
}
