using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase que implementa la interfaz IMotor
    /// </summary>
    public class MotorGasolina : IMotor
    {
        /// <summary>
        /// Propiedad que almacena las revoluciones, no se puede modificar directamente, solo desde el constructor se inicializa
        /// </summary>
        public int intRevoluciones { get; private set; }

        /// <summary>
        /// constructor, inicializa las revoluciones
        /// </summary>
        public MotorGasolina()
        {
            intRevoluciones = 300;
        }

        /// <summary>
        /// Método para acelerar el motor, el tipo de motor a gasolina se acelera cada 50 revoluciones
        /// </summary>
        public void AcelararMotor()
        {
            intRevoluciones += 50;
            Console.WriteLine("Acelando a " + intRevoluciones);
        }

        /// <summary>
        /// Método para desacelerar el motor, el tipo de motor a gasolina se desacelera cada 50 revoluciones
        /// </summary>
        public void DesAcelararMotor()
        {
            intRevoluciones -= 50;
            Console.WriteLine("Desacelando a " + intRevoluciones);
        }
    }
}
