using System;
using System.Collections.Generic;

namespace Parte1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parte 1 Bucles
            //FOR
            for (int i = 1; i <= 50; i++)
            {
                if (i == 25)
                {
                    Console.WriteLine("Se alcanzó el 25. Fin del bucle.");
                    break;
                }
                if (i % 5 == 0)
                {
                    continue; // Salta múltiplos de 5
                }

                Console.WriteLine(i);
            }

            // Ciclo FOREACH 
            //Lista de nombres
            List<string> estudiantes = new List<string>() { "Juan", "Luis", "María", "Ana", "Pedro", "Raquel" };
            foreach (string nombre in estudiantes)
            {
                if (nombre == "Ana")
                {
                    continue; // No saludar a Ana

                }

                Console.WriteLine("Hola " + nombre);
            }


            //Ciclo Do WHILE
            while (true)
            {
                Console.WriteLine("Ingresa un número positivo (0 para salir): ");
                string input = Console.ReadLine();
                int numero;

                // Validate parse
                if (!int.TryParse(input, out numero))
                {
                    Console.WriteLine("Entrada invalida");
                    continue;
                }

                if (numero == 0)
                {
                    Console.WriteLine("Fin del programa");
                    break;
                }

                if (numero > 100)
                {
                    Console.WriteLine("Número mayor a 100. Se detiene el ciclo.");
                    break;
                }
                if (numero > 0)
                {
                    Console.WriteLine("Número válido: " + numero);
                }
                else
                {
                    Console.WriteLine("Solo números positivos.");
                    continue;
                }

                // Do WHILE + Switch
                int opcion;

                do
                {
                    Console.WriteLine("Menú:");
                    Console.WriteLine("1. Mostrar números pares");
                    Console.WriteLine("2. Mostrar números impares");
                    Console.WriteLine("3. Salir");
                    Console.Write("Selecciona una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Opción inválida.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Números pares del 1 al 20:");
                            for (int i = 1; i <= 20; i++)
                            {
                                if (i % 2 == 0)
                                Console.WriteLine(i + " ");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Números impares del 1 al 20:");
                            for (int i = 1; i <= 20; i++)
                            {
                                Console.WriteLine(i + " ");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Saliendo del menú...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                } while (opcion != 3);

            }
        }
    }
}