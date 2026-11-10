
using System;

class Program
{
    static void Main(string[] args)
    {
        // Credenciales correctas
        string usuarioCorrecto = "soporteDB";
        string contrasenaCorrecta = "Sistemas2025";

        // Variables de control
        string usuario;
        string contrasena;
        int intentos = 0;
        bool conectado = false;

        do
        {
            // Solicitar credenciales
            Console.Write("Ingrese el usuario: ");
            usuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            contrasena = Console.ReadLine();

            // Simular servidor caído
            if (usuario == "admin")
            {
                Console.WriteLine("Servidor no disponible. Reintente más tarde.");
            }
            else
            {
                // Verificar credenciales
                if (usuario == usuarioCorrecto &&
                    contrasena == contrasenaCorrecta)
                {
                    Console.WriteLine("Conexión establecida con la base de datos.");
                    conectado = true;
                }
                else
                {
                    intentos++;

                    Console.WriteLine("Error de autenticación. Intento " 
                        + intentos + " de 3.");
                }
            }

        } while (conectado == false && intentos < 3);

        // Verificar si se agotaron los intentos
        if (conectado == false)
        {
            Console.WriteLine("Conexión bloqueada por seguridad.");
            Console.WriteLine("Comuníquese con el administrador del sistema.");
        }
    }
}
