using System;

namespace Capitulo_1_al_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Option;

            //Mostrando el menu principal
            Console.WriteLine("Seleccione Cual Capitulo quiere Ver");
            Console.WriteLine("1. Capitulo 1");
            Console.WriteLine("2. Capitulo 2");
            Console.WriteLine("3. Capitulo 3");
            Console.WriteLine("4. Salir");
            Console.ReadKey();
            Console.Clear();

            do
            {

                Option = Convert.ToInt32(Console.ReadLine());

                if (Option != 4)
                {
                    switch (Option)
                    {

                      case 1:

                            //Mostrando el sub menu 1
                            Console.WriteLine("Selecciono el Capitulo 1: ");
                            Console.WriteLine("1) Ejercicio #1");
                            Console.WriteLine("5) Ejercicio #5");

                            Option = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (Option)
                            {

                                case 1:
                                    Console.WriteLine("Ejercicio #1");
                                    Capitulo_1_Ejercicio_1 Capitulo1Ejercicio1 = new Capitulo_1_Ejercicio_1();
                                    Capitulo1Ejercicio1.Display();
                                    break;

                                case 5:
                                    Console.WriteLine("Ejercicio #5");
                                    Capitulo_1_Ejercicio_5 Capitulo1Ejercicio5 = new Capitulo_1_Ejercicio_5();
                                    Capitulo1Ejercicio5.Display();
                                    break;
                            }
                            break;

                        case 2:

                            //Mostrando el sub menu 2
                            Console.WriteLine("Selecciono el Capitulo 2: ");
                            Console.WriteLine("1) Ejercicio #1");
                            Console.WriteLine("3) Ejercicio #3");
                            Console.WriteLine("5) Ejercicio #5");
                            Option = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Ejercicio #1");
                                    Capitulo_2_Ejercicio_1 Capitulo2Ejercicio1 = new Capitulo_2_Ejercicio_1();
                                    Capitulo2Ejercicio1.Calculate();
                                    break;

                                case 3:
                                    Console.WriteLine("Ejercicio #3");
                                    Capitulo_2_Ejercicio_3 Capitulo2Ejercicio3 = new Capitulo_2_Ejercicio_3();
                                    Capitulo2Ejercicio3.Calculate();
                                    break;

                                case 5:
                                    Console.WriteLine("Ejercicio #5");
                                    Capitulo_2_Ejercicio_5 Capitulo2Ejercicio5 = new Capitulo_2_Ejercicio_5();
                                    Capitulo2Ejercicio5.Calculate();
                                    break;

                            }break;

                        case 3:

                            //Mostrando el sub menu 3
                            Console.WriteLine("Selecciono el Capitulo 3: ");
                            Console.WriteLine("1) Ejercicio #1");
                            Console.WriteLine("4) Ejercicio #4");
                            Option = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Ejercicio #1");
                                    Capitulo_3_Ejercicio_1 Capitulo3Ejercicio1 = new Capitulo_3_Ejercicio_1();
                                    Capitulo3Ejercicio1.Calculate();
                                    break;

                                case 4:
                                    Console.WriteLine("Ejercicio #4");
                                    Capitulo_3_Ejercicio_4 Capitulo3Ejercicio4 = new Capitulo_3_Ejercicio_4();
                                    Capitulo3Ejercicio4.Display();
                                    break;

                            }
                            break;

                    }
                    break;

                }    
            } while (Option != 4);
                    Console.ReadKey();
        }

    }
}
