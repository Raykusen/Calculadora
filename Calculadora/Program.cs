using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                // Mostrar menú
                Console.WriteLine("\nCalculadora\n");
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicación");
                Console.WriteLine("4- División");
                Console.WriteLine("5- Elevar un número a la potencia");
                Console.WriteLine("6- Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                // Realizar la operación seleccionada
                switch (opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        Potencia();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

            } while (opcion != 6); // Repetir el menú hasta que el usuario elija salir
        }

        // Método para la suma
        static void Sumar()
        {
            Console.Write("Ingresa el primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a + b;
            Console.WriteLine("Resultado de la suma: " + resultado);
        }

        // Método para la resta
        static void Restar()
        {
            Console.Write("Ingresa el primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine("Resultado de la resta: " + resultado);
        }

        // Método para la multiplicación
        static void Multiplicar()
        {
            Console.Write("Ingresa el primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine("Resultado de la multiplicación: " + resultado);
        }

        // Método para la división
        static void Dividir()
        {
            Console.Write("Ingresa el primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double b = double.Parse(Console.ReadLine());

            if (b != 0)
            {
                double resultado = a / b;
                Console.WriteLine("Resultado de la división: " + resultado);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
        }

        // Método para elevar a una potencia
        static void Potencia()
        {
            Console.Write("Ingresa el número base: ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el exponente: ");
            double exponente = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine("Resultado de la potencia: " + resultado);
        }
    }
}
