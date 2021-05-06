using System;

namespace Capitulo_1_al_3
{
    class Capitulo_2_Ejercicio_1
    {
        public void Calculate()
        {
            //Declaracion de variables
            int Lado_a;
            int Lado_b;
            int Lado_c;
            int Lado_d;
            int Perimetro;

            //Introduccion de Valores
            Console.WriteLine("Escribe el Primer valor");
            Lado_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el Segundo Valor");
            Lado_b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el Tercer Valor");
            Lado_c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el Cuarto Valor");
            Lado_d = Convert.ToInt32(Console.ReadLine());

            //Calculo del Parimetro
            Perimetro = Lado_a + Lado_b + Lado_c + Lado_d;

            //Mostrando Resultado
            Console.WriteLine("Resultado Del Poligono es {0}", Perimetro + " CM");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
