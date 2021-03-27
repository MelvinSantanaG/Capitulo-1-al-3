using System;

namespace Capitulo_1_al_3
{
    class Capitulo_2_Ejercicio_5
    {
        public void Calculate()
        {
            //Declaracion de variables y Introducion de datos

            Console.WriteLine("Introduce la cantidad en Dolores ");
            int Dolares = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tipo de cambio del dia en Euros ");
            int Euros = Convert.ToInt32(Console.ReadLine());

            //Calculado el Cambio de Moneda
            int Cambio = Dolares* Euros;

            //Mostrando el Resultado
            Console.WriteLine("El valor de {0} dolares en euro es {1} euros", Dolares, Cambio);
            Console.ReadKey();
        }
    }
}
