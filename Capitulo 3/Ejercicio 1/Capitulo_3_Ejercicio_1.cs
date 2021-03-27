using System;

namespace Capitulo_1_al_3
{
    class Capitulo_3_Ejercicio_1
    {

        public void Calculate()
        {
            //Declaracion de variables y Introducion el Numero
            Console.WriteLine("Introduce un numero entero");
            int Numero = Convert.ToInt32(Console.ReadLine());

            //Calculado si es Par o Impar
            if (Numero % 2 == 0)
            {
                //Mostrando el Resultado Para Par
                Console.WriteLine("Es Par");
            }
            else
            {
                //Mostrando el Resultado Para Impar
                Console.WriteLine("Es Impar");
            }
            Console.ReadKey();
        }
    }
}
