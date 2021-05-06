using System;

namespace Capitulo_1_al_3
{
    class Capitulo_2_Ejercicio_3
    {
        public void Calculate()
        {
            //Declaracion de variables
            double Grados;
            double Radianes;
            const double PI = Math.PI;
            const double ANGULO = 180;

            //Introducion de datos
            Console.Write("Introduce el valor de los grados para convertir ");
            Grados = Convert.ToDouble(Console.ReadLine());

            //Calculado el Resultado
            Radianes = Grados * (ANGULO / PI);

            //Mostrando el Resultado
            Console.WriteLine("Los grados son {0}° el Valor de los {1} radianes", Grados, Radianes);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
