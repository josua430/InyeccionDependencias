using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Interfaz para Inversion de Control, inyecion de dependencias. Interfaz para asociar a un motoe genérico
    /// </summary>
    public interface IMotor
    {
        /// <summary>
        /// propiedad revoluciones que contiene todo motor
        /// </summary>
        int intRevoluciones { get; }

        /// <summary>
        /// Método para acelerar el motor
        /// </summary>
        void AcelararMotor();

        /// <summary>
        /// Método para desacelerar el motor
        /// </summary>
        void DesAcelararMotor();
    }
}
