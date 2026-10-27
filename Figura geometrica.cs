
using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Cuadrado hueco");
            Console.WriteLine("2. Triangulo invertido");
            Console.WriteLine("3. Piramide centrada");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nCuadrado hueco:");

                    for (int fila = 0; fila < 5; fila++)
                    {
                        for (int columna = 0; columna < 5; columna++)
                        {
                            if (fila == 0 || fila == 4 ||
                                columna == 0 || columna == 4)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("\nTriangulo invertido:");

                    for (int fila = 5; fila >= 1; fila--)
                    {
                        for (int columna = 1; columna <= fila; columna++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("\nPiramide centrada:");

                    for (int fila = 1; fila <= 5; fila++)
                    {
                        for (int espacio = 1; espacio <= 5 - fila; espacio++)
                        {
                            Console.Write(" ");
                        }

                        for (int asterisco = 1; asterisco <= 2 * fila - 1; asterisco++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 4);
    }
}
