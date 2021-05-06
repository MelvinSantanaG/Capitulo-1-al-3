using System;

namespace Capitulo_1_al_3
{
    class Capitulo_3_Ejercicio_4
    {
        public void Display()
        {
            //Mostrando el menu
            Console.WriteLine("1. Lunes");
            Console.WriteLine("2. Martes");
            Console.WriteLine("3. Miercoles");
            Console.WriteLine("4. Jueves");
            Console.WriteLine("5. Viernes");
            Console.WriteLine("6. Sabado");
            Console.WriteLine("7. Domingo");
            Console.WriteLine("Digite el dia de la Semana");

            //Pidiendo el Numero del 1 al 7 de la Semana
            //Declaracion de variables y Pidendo el numero 
            int Numero = Convert.ToInt32(Console.ReadLine());

            switch (Numero)
            {
                case 1:
                    Console.Write("Lunes");
                    break;

                case 2:
                    Console.Write("Martes");
                    break;

                case 3:
                    Console.Write("Miercoles");
                    break;

                case 4:
                    Console.Write("Jueves");
                    break;

                case 5:
                    Console.Write("Viernes");
                    break;

                case 6:
                    Console.Write("Sabados");
                    break;

                case 7:
                    Console.Write("Domingo");
                    break;

                default:
                    Console.Write("error");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
