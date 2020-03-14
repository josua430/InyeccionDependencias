using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase que implementa la interfaz IMotor, motor JET A1, de aviones
    /// </summary>
    public class MotorJetA1 : IMotor
    {
        /// <summary>
        /// Propiedad que almacena las revoluciones, no se puede modificar directamente, solo desde el constructor se inicializa
        /// </summary>
        public int intRevoluciones { get; private set; }

        /// <summary>
        /// constructor, inicializa las revoluciones
        /// </summary>
        public MotorJetA1()
        {
            intRevoluciones = 1000;
        }

        /// <summary>
        /// Método para acelerar el motor, el tipo de motor jet a1 se acelera cada 250 revoluciones
        /// </summary>
        public void AcelararMotor()
        {
            intRevoluciones += 250;
            Console.WriteLine("Acelando a " + intRevoluciones);
        }

        /// <summary>
        /// Método para desacelerar el motor, el tipo de motor de avion se desacelera cada 250 revoluciones
        /// </summary>
        public void DesAcelararMotor()
        {
            intRevoluciones -= 250;
            Console.WriteLine("Desacelando a " + intRevoluciones);
        }
    }
}
