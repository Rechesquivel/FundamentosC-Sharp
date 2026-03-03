using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Parte2_Seguridad // Note: actual namespace depends on the project name.
{
    public class Parte2_Seguridad
    {
        static void Main(string[] args)
        {
            // Validación de datos
            Console.WriteLine("Validacion de datos:");

            Console.WriteLine("Ingrese su edad: ");
            string edadInput = Console.ReadLine();
            int edad;

            if (int.TryParse(edadInput, out edad))
            {
                Console.WriteLine("Edad válida: " + edad);
            }
            else
            {
                Console.WriteLine("Edad inválida.");
            }

            Console.WriteLine("Ingrese su correo electronico: ");
            string correo = Console.ReadLine();

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool esCorreoValido = Regex.IsMatch(correo, patronCorreo);

            if (esCorreoValido)
            {
                Console.WriteLine("Correo válido");
            }
            else
            {
                Console.WriteLine("Correo inválido");
            }

            //Hashing + salting
            Console.WriteLine("hashing con sha-256");
            Console.WriteLine("Ingrese una contraseña: ");
            string password = Console.ReadLine();

            //Generar salting aleatorio
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string saltString = Convert.ToBase64String(salt);

            //Combinar contraseña + salt
            string passwordConSalt = password + saltString;

            // Crear hash con SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(passwordConSalt);
                byte[] hash = sha256.ComputeHash(bytes);

                string hashString = Convert.ToBase64String(hash);

                Console.WriteLine("Contraseña original: " + password);
                Console.WriteLine("Salt generado: " + saltString);
                Console.WriteLine("Hash SHA-256: " + hashString);
            }

            //Prevención de ataques de inyección SQL (Simulado)
            Console.WriteLine("Prevención de ataques de inyección SQL (Simulado)");

            string usuario = "admin";
            string pass = "1234";

            // Forma insegura  (vulnerable a inyección SQL)
            string consultaInsegura = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "' AND pass = '" + pass + "'";
            Console.WriteLine("Consulta insegura:");
            Console.WriteLine(consultaInsegura);

            // Forma segura (usando parámetros)
            string consultaSegura = "SELECT * FROM usuarios WHERE usuario = @usuario AND pass = @pass";
            Console.WriteLine("Consulta segura:");
            Console.WriteLine(consultaSegura);

            /* ¿Por qué es importante la validación de datos?
             * La validación de datos es crucial para garantizar que la información ingresada por los usuarios sea correcta, segura y esté en el formato esperado. Esto ayuda a prevenir errores, ataques de inyección, y asegura que el sistema funcione de manera confiable.
             * 
             * ¿Qué es el hashing y el salting?
             * El hashing es un proceso que convierte una entrada (como una contraseña) en una cadena de longitud fija, que parece aleatoria. El salting es la adición de un valor aleatorio (salt) a la contraseña antes de hashearla, lo que hace que cada hash sea único incluso si dos usuarios tienen la misma contraseña.
             * 
             * ¿Cómo se pueden prevenir los ataques de inyección SQL?
             * Para prevenir los ataques de inyección SQL, se deben usar consultas parametrizadas o procedimientos almacenados en lugar de concatenar directamente las entradas del usuario en las consultas SQL. Esto asegura que las entradas del usuario sean tratadas como datos y no como parte del código SQL.
             */
        }
    }
}

