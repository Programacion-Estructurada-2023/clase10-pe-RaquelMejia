using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //EJERCICIO CLASE 10. ESTRUCTURA SELECTIVA SWITCH/CASE
            //REALIZAR  UN PROGRAMA QUE AL INGRESAR UN NUMERO , MUESTRE EL MES QUE CORRESPONDA
            //CREAR UN MENU DE OPCIONES
            Console.WriteLine("Elija un numero que corresponda a un Mes del primer semestre: del 1 al 6");
            Console.WriteLine("1. Mes de Enero");
            Console.WriteLine("2. Mes de Febrero");
            Console.WriteLine("3. Mes de Marzo");
            Console.WriteLine("4. Mes de Abril");
            Console.WriteLine("5. Mes de Mayo");
            Console.WriteLine("6. Mes de junio");

            Console.WriteLine("\nIngresa un numero entre 1 y 6:\n");
            int numero_Mes = Convert.ToInt32(Console.ReadLine());

            switch (numero_Mes)
            {
                case 1:
                    Console.WriteLine("El numero ingresado " + numero_Mes + " corresponde al mes de Enero");
                    break;
                case 2:
                    Console.WriteLine("El numero ingresado " + numero_Mes + " corresponde al mes de Febrero ");
                    break;
                case 3:
                    Console.WriteLine("El numero ingresado " + numero_Mes + " corresponde al mes de Marzo ");
                    break;
                case 4:
                    Console.WriteLine("El numero ingresado " + numero_Mes + " corresponde al mes de Abril ");
                    break;
                case 5:
                    Console.WriteLine("El numero ingresado " + numero_Mes + " corresponde al mes de Mayo ");
                    break;
                case 6:
                    Console.WriteLine("El numero ingresado " + numero_Mes + " corresponde al mes de Junio ");
                    break;
                default:
                    Console.WriteLine("El numero ingresado no corresponde a ningun mes del primer semestre, Por favor ingresa un dato valido del 1 al 6");
                    break;
            }
            Console.ReadLine();
        }
    }
}

