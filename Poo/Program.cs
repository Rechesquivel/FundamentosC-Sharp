using System;
using poo;
using Poo;

namespace poo // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Persona persona1 = new Persona();
            //Console.WriteLine(persona1.GetNombre());

            //persona1.SetNombre("Maria");
            //string nombrePersona1 = persona1.GetNombre();
            //persona1.Edad = 23;
            //Console.WriteLine("Modificando atributo Nombre...");
            //Console.WriteLine(persona1.GetNombre());
            //Console.WriteLine($"La Persona1 se llama {nombrePersona1}, y tiene { persona1.Edad} anios");

            //Persona persona2 = new Persona();
            //persona2.SetNombre("José");
            //string nombrePersona2 = persona2.GetNombre();
            //persona2.Edad= 30;
            
            //Console.WriteLine($"La Persona2 + llama {persona2.GetNombre()}, y tiene {persona2.Edad} anios");


            //Persona persona3 = new Persona("Ana", 21);
            //Console.WriteLine($"La Persona3 se llama {persona3.GetNombre()}, y tiene { persona3.Edad} anios");

            Estudiante estudiante1 = new Estudiante("Jeffry", 35, "Ingeniería Informatica");
            Estudiantebecado estudiante2 = new Estudiante
            estudiante1.SetNombre("Jeffry");
            estudiante1.Edad = 35;
            estudiante.MostrarInfo();
        }
    }
}
