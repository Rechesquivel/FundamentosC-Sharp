using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public abstract class Persona
    {
        //Atributos privados
        private string Nombre;

        //Encapsulamiento con propiedades
        public int Edad { get; set; }

        //Constructor sin parametros
        public Persona()
        {
            this.Nombre = "Juan";
        }

        //Constructor con parámetros
        public Persona(String nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public void SetNombre(string nuevonombre)
        {
            this.Nombre = nuevonombre;
        }
        public string GetNombre()
        {
            return this.Nombre;
        }

        //Abstracto: Método sin implementación, que debe ser implementado por las clases derivadas

        public abstract void MostrarInfo();

        //Método virtual: Puede ser redefinido
        public virtual decimal CalcularPago()
        {
            return 1000; //tarifa general
        }
    }
}

