using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase que implementa la interfaz IMotor, tipo de motor diesel
    /// </summary>
    public class MotorDiesel : IMotor
    {
        /// <summary>
        /// Propiedad que almacena las revoluciones, no se puede modificar directamente, solo desde el constructor se inicializa
        /// </summary>
        public int intRevoluciones { get; private set; }

        /// <summary>
        /// constructor, inicializa las revoluciones
        /// </summary>
        public MotorDiesel()
        {
            intRevoluciones = 400;
        }

        /// <summary>
        /// Método para acelerar el motor, el tipo de motor a diesel se acelera cada 100 revoluciones
        /// </summary>
        public void AcelararMotor()
        {
            intRevoluciones += 100;
            Console.WriteLine("Acelando a " + intRevoluciones);
        }

        /// <summary>
        /// Método para desacelerar el motor, el tipo de motor a diesel se desacelera cada 100 revoluciones
        /// </summary>
        public void DesAcelararMotor()
        {
            intRevoluciones -= 100;
            Console.WriteLine("Desacelando a " + intRevoluciones);
        }
    }
}
