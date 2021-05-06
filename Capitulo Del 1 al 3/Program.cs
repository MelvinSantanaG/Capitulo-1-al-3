using System;

namespace Capitulo_1_al_3
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("* Seleccione Cual Capitulo Quiere Ver *");
            Console.WriteLine("* 1. Capitulo 1                       *");
            Console.WriteLine("* 2. Capitulo 2                       *");
            Console.WriteLine("* 3. Capitulo 3                       *");
            Console.WriteLine("***************************************");
        }

        public static void MensajeParaException()
        {
            Console.WriteLine("Introdujo Una Letra Digite El Numero Que Se Nuestra En El Menu");
        }

        static void Main(string[] args)
        {
            int Option;
            bool ok;

            Console.WriteLine("Presione Cualquier tecla Para iniciar");
            Console.ReadKey();
            Console.Clear();

            try
            {
                ok = true;
                do
                {
                    try
                    {
                        //Función Estatica Que Muestra el Menu Principal
                        Menu();

                        Option = Convert.ToInt32(Console.ReadLine());

                        if (Option < 4)
                        {
                            
                            Console.WriteLine("Por Favor Repite El Numero " + Option + " Nuevamente\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            ok = false;
                            Console.WriteLine("Ha Seleccionado El Numero " + Option + " Este No Pertence al Rango del Menu Principal");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        switch (Option)
                        {

                            case 1:
                                //Mostrando el sub menu 1
                                try
                                {
                                    ok = true;
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("*****************************");
                                            Console.WriteLine("* Selecciono el Capitulo 1: *");
                                            Console.WriteLine("* 1) Ejercicio #1           *");
                                            Console.WriteLine("* 5) Ejercicio #5           *");
                                            Console.WriteLine("*****************************");

                                            Option = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();

                                            switch (Option)
                                            {
                                                case 1:
                                                    Console.WriteLine("Selecciono El Ejercicio #1 Del Capitulo #1");
                                                    Capitulo_1_Ejercicio_1 Capitulo1Ejercicio1 = new Capitulo_1_Ejercicio_1();
                                                    Capitulo1Ejercicio1.Display();
                                                    break;

                                                case 5:
                                                    Console.WriteLine("Selecciono El Ejercicio #5 Del Capitulo #1");
                                                    Capitulo_1_Ejercicio_5 Capitulo1Ejercicio5 = new Capitulo_1_Ejercicio_5();
                                                    Capitulo1Ejercicio5.Display();
                                                    break;

                                                default:
                                                    Console.WriteLine("Ha Seleccionado El " + Option + " Intente De Nuevo");
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            MensajeParaException();
                                            ok = false;
                                        }
                                    } while (ok == false);
                                }
                                finally { }
                                break;

                            case 2:
                                try
                                {
                                    ok = true;
                                    do
                                    {
                                        try
                                        {
                                            //Mostrando el sub menu 2
                                            Console.WriteLine("*****************************");
                                            Console.WriteLine("* Selecciono el Capitulo 2: *");
                                            Console.WriteLine("* 1) Ejercicio #1           *");
                                            Console.WriteLine("* 3) Ejercicio #3           *");
                                            Console.WriteLine("* 5) Ejercicio #5           *");
                                            Console.WriteLine("*****************************");
                                            Option = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();

                                            switch (Option)
                                            {
                                                case 1:
                                                    Console.WriteLine("Selecciono El Ejercicio #1 Del Capitulo #2");
                                                    Capitulo_2_Ejercicio_1 Capitulo2Ejercicio1 = new Capitulo_2_Ejercicio_1();
                                                    Capitulo2Ejercicio1.Calculate();
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Selecciono El Ejercicio #3 Del Capitulo #2");
                                                    Capitulo_2_Ejercicio_3 Capitulo2Ejercicio3 = new Capitulo_2_Ejercicio_3();
                                                    Capitulo2Ejercicio3.Calculate();
                                                    break;

                                                case 5:
                                                    Console.WriteLine("Selecciono El Ejercicio #5 Del Capitulo #2");
                                                    Capitulo_2_Ejercicio_5 Capitulo2Ejercicio5 = new Capitulo_2_Ejercicio_5();
                                                    Capitulo2Ejercicio5.Calculate();
                                                    break;

                                                default:
                                                    Console.WriteLine("Ha Seleccionado El " + Option + " Intente De Nuevo");
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            MensajeParaException();
                                            ok = false;
                                        }
                                    } while (ok == false);
                                }
                                finally { }
                                break;

                            case 3:
                                try
                                {
                                    //Mostrando el sub menu 3
                                    ok = true;
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("*****************************");
                                            Console.WriteLine("* Selecciono el Capitulo 3: *");
                                            Console.WriteLine("* 1) Ejercicio #1           *");
                                            Console.WriteLine("* 4) Ejercicio #4           *");
                                            Console.WriteLine("*****************************");
                                            Option = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();

                                            switch (Option)
                                            {
                                                case 1:
                                                    Console.WriteLine("Selecciono El Ejercicio #1 Del Capitulo #3");
                                                    Capitulo_3_Ejercicio_1 Capitulo3Ejercicio1 = new Capitulo_3_Ejercicio_1();
                                                    Capitulo3Ejercicio1.Calculate();
                                                    break;

                                                case 4:
                                                    Console.WriteLine("Selecciono El Ejercicio #4 Del Capitulo #3");
                                                    Capitulo_3_Ejercicio_4 Capitulo3Ejercicio4 = new Capitulo_3_Ejercicio_4();
                                                    Capitulo3Ejercicio4.Display();
                                                    break;

                                                default:
                                                    Console.WriteLine("Ha Seleccionado El " + Option + " Intente De Nuevo");
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            MensajeParaException();
                                            ok = false;
                                        }
                                    } while (ok == false);
                                }
                                finally { }
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        MensajeParaException();
                        ok = false;
                    }
                } while (ok == false);
            }
            finally{}
        }
    }
}
