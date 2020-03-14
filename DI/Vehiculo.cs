using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    /// <summary>
    /// Clase que usa un motor genérico (interfaz IMotor)
    /// </summary>
    public class Vehiculo
    {
        /// <summary>
        /// Motor genérico que usa la clase
        /// </summary>
        IMotor Motor = null;

        /// <summary>
        /// paso de interfaz por el constructor
        /// </summary>
        /// <param name="miMotor">Interfaz de motor</param>
        public Vehiculo(IMotor miMotor)
        {
            Motor = miMotor;
        }

        /// <summary>
        /// Método para mostrar las revoluciones iniciales del motor
        /// </summary>
        public void RevolucionesIniciales()
        {
            Console.WriteLine("Revoluciones iniciales motor: " + Motor.intRevoluciones);
        }

        /// <summary>
        /// Método para acelerar el motor
        /// </summary>
        public void Acelarar()
        {
            Motor.AcelararMotor();
            
        }
    }
}
