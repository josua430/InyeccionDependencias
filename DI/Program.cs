using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Inversion de control con Inyeccion de dependencia con persona, se crea la clase especifica a usar de tipo IAlimento
            //{
            //    //Con la interfaz IAlimento
            //    IAlimento ElAlimento = null;

            //     //Uso 1,  Alimento de tipo pizza
            //    //ElAlimento = new Pizza("Champiñones");

            //     //Uso 2,  Alimento de tipo hamburguesa
            //    ElAlimento = new Hamburguesa() { TipoDeHamburguesa = "Doble carne" };


            //    Persona Yo = new Persona(ElAlimento);
            //    Yo.Comer();
            //}

            //DI con Vehiculo
            {
                //motor genérico, para pasar como inyeccion de dependencia
                IMotor miMotorAUsar = null;

                //Uso 1. Voy a usar un motor de gasolina
                //miMotorAUsar = new MotorGasolina();

                //Uso 2. Voy a usar un motor de Diesel
                //miMotorAUsar = new MotorDiesel();

                //Uso 3. Voy a usar un motor de Avion
                miMotorAUsar = new MotorJetA1();

                //uso el motor el momento de crear el objeto
                Vehiculo miCarro = new Vehiculo(miMotorAUsar);
                miCarro.RevolucionesIniciales();
                miCarro.Acelarar();

            }
        }
    }
}
